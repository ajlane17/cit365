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
    public class IndexModel : PageModel
    {
        private readonly CIT365_SacramentProgram.Data.SacramentContext _context;

        public IndexModel(CIT365_SacramentProgram.Data.SacramentContext context)
        {
            _context = context;
        }

        public string DateSort { get; set; }

        public IList<Meeting> Meeting { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Meeting> meetingsIQ = from m in _context.Meeting
                                             select m;

            switch (sortOrder)
            {
                case "Date":
                    meetingsIQ = meetingsIQ.OrderBy(s => s.MeetingDate);
                    break;
                case "date_desc":
                    meetingsIQ = meetingsIQ.OrderByDescending(s => s.MeetingDate);
                    break;
                default:
                    meetingsIQ = meetingsIQ.OrderBy(s => s.MeetingDate);
                    break;
            }

            Meeting = await meetingsIQ
                .Include(m => m.Speakers)
                .ToListAsync();
        }
    }
}
