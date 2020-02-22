using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal
{
    public class EditModel : PageModel
    {
        private readonly MyScriptureJournal.Data.ScriptureRecordContext _context;

        public EditModel(MyScriptureJournal.Data.ScriptureRecordContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            // Update the modified date on save
            ScriptureRecord.ModifiedDate = DateTime.UtcNow;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ScriptureRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScriptureRecordExists(ScriptureRecord.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ScriptureRecordExists(int id)
        {
            return _context.ScriptureRecord.Any(e => e.ID == id);
        }
    }
}
