using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIT365_SacramentProgram.Data;
using CIT365_SacramentProgram.Models;

namespace CIT365_SacramentProgram.Pages.Meetings
{
    public class DetailsModel : PageModel
    {
        private readonly CIT365_SacramentProgram.Data.SacramentContext _context;

        public DetailsModel(CIT365_SacramentProgram.Data.SacramentContext context)
        {
            _context = context;
        }

        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meeting = await _context.Meeting
                .Include(m => m.Speakers)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Meeting == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
