using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIT365_SacramentProgram.Data;
using CIT365_SacramentProgram.Models;

namespace CIT365_SacramentProgram.Pages.Speakers
{
    public class DeleteModel : PageModel
    {
        private readonly CIT365_SacramentProgram.Data.SacramentContext _context;

        public DeleteModel(CIT365_SacramentProgram.Data.SacramentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Speaker Speaker { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Speaker = await _context.Speakers.FirstOrDefaultAsync(m => m.SpeakerId == id);

            if (Speaker == null)
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

            Speaker = await _context.Speakers.FindAsync(id);

            if (Speaker != null)
            {
                _context.Speakers.Remove(Speaker);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
