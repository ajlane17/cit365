using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Data
{
    public class ScriptureRecordContext : DbContext
    {
        public ScriptureRecordContext (DbContextOptions<ScriptureRecordContext> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureJournal.Models.ScriptureRecord> ScriptureRecord { get; set; }
    }
}
