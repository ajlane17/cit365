using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CIT365_SacramentProgram.Models;

namespace CIT365_SacramentProgram.Data
{
    public class SacramentContext : DbContext
    {
        public SacramentContext (DbContextOptions<SacramentContext> options)
            : base(options)
        {
        }

        public DbSet<CIT365_SacramentProgram.Models.Meeting> Meeting { get; set; }

        public DbSet<Speaker> Speakers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Speaker>()
                .Property(e => e.Type)
                .HasConversion(
                    v => v.ToString(),
                    v => (SpeakerType)Enum.Parse(typeof(SpeakerType), v));
        }
    }
}
