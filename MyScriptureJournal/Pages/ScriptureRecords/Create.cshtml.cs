using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal
{
    public class CreateModel : PageModel
    {
        private readonly MyScriptureJournal.Data.ScriptureRecordContext _context;

        public CreateModel(MyScriptureJournal.Data.ScriptureRecordContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ScriptureRecord ScriptureRecord { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            // Add the created date and modified date on save
            DateTime currTime = DateTime.UtcNow;
            ScriptureRecord.CreatedDate = currTime;
            ScriptureRecord.ModifiedDate = currTime;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ScriptureRecord.Add(ScriptureRecord);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
