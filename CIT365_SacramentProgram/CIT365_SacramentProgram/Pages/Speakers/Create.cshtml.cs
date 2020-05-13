using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CIT365_SacramentProgram.Data;
using CIT365_SacramentProgram.Models;

namespace CIT365_SacramentProgram.Pages.Speakers
{
    public class CreateModel : PageModel
    {
        private readonly CIT365_SacramentProgram.Data.SacramentContext _context;

        public Meeting Meeting { get; set; }

        public CreateModel(CIT365_SacramentProgram.Data.SacramentContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meeting = await _context.Meeting.FirstOrDefaultAsync(m => m.Id == id);

            if (Meeting == null)
            {
                return NotFound();
            }
            return Page();
        }

        [BindProperty]
        public Speaker Speaker { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptySpeaker = new Speaker();

            if (await TryUpdateModelAsync<Speaker>(
                emptySpeaker,
                "speaker",
                s => s.FullName, s => s.Topic, s=> s.Type, s=> s.MeetingId))
            {
                _context.Speakers.Add(emptySpeaker);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Meetings/Details", new { id = emptySpeaker.MeetingId });
        }
    }
}
