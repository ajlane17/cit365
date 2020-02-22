using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal
{
    public class DeleteModel : PageModel
    {
        private readonly MyScriptureJournal.Data.ScriptureRecordContext _context;

        public DeleteModel(MyScriptureJournal.Data.ScriptureRecordContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ScriptureRecord ScriptureRecord { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ScriptureRecord = await _context.ScriptureRecord.FirstOrDefaultAsync(m => m.ID == id);

            if (ScriptureRecord == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ScriptureRecord = await _context.ScriptureRecord.FindAsync(id);

            if (ScriptureRecord != null)
            {
                _context.ScriptureRecord.Remove(ScriptureRecord);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
