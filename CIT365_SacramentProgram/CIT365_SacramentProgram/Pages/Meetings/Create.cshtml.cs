using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIT365_SacramentProgram.Data;
using CIT365_SacramentProgram.Models;

namespace CIT365_SacramentProgram.Pages.Meetings
{
    public class CreateModel : PageModel
    {
        private readonly CIT365_SacramentProgram.Data.SacramentContext _context;

        public CreateModel(CIT365_SacramentProgram.Data.SacramentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Meeting Meeting { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Meeting.Add(Meeting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details", new { id = Meeting.Id });
        }
    }
}
