using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.ScriptureRecordContext _context;

        public IndexModel(MyScriptureJournal.Data.ScriptureRecordContext context)
        {
            _context = context;
        }

        public IList<ScriptureRecord> ScriptureRecords { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Books { get; set; }

        [BindProperty(SupportsGet = true)]
        public string BookName { get; set; }

        public string BookSort { get; set; }

        public string CreatedSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            CreatedSort = sortOrder == "created_date" ? "created_date_desc" : "created_date";

            IQueryable<string> bookQuery = from m in _context.ScriptureRecord orderby m.Book select m.Book;

            IQueryable<ScriptureRecord> scriptureRecords = from m in _context.ScriptureRecord select m;

            switch (sortOrder)
            {
                case "book_desc":
                    scriptureRecords = scriptureRecords.OrderByDescending(s => s.Book);
                    break;
                case "created_date":
                    scriptureRecords = scriptureRecords.OrderBy(s => s.CreatedDate);
                    break;
                case "created_date_desc":
                    scriptureRecords = scriptureRecords.OrderByDescending(s => s.CreatedDate);
                    break;
                default:
                    scriptureRecords = scriptureRecords.OrderBy(s => s.Book);
                    break;
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptureRecords = scriptureRecords.Where(s => s.Comments.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(BookName))
            {
                scriptureRecords = scriptureRecords.Where(x => x.Book == BookName);
            }

            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            ScriptureRecords = await scriptureRecords.ToListAsync();
        }
    }
}
