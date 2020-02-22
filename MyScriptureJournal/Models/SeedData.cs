using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureRecordContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureRecordContext>>()))
            {
                // Look for any movies.
                if (context.ScriptureRecord.Any())
                {
                    return;   // DB has been seeded
                }

                context.ScriptureRecord.AddRange(
                    new ScriptureRecord
                    {
                        Book = "John",
                        Chapter = 3,
                        Verse = 16,
                        Comments = "The Divine love to the whole of humanity in its condition of supreme need, i.e. apart from himself " +
                                   "and his grace, has been of such a commanding, exhaustless, immeasurable kind, that it was equal to any " +
                                   "emergency, and able to secure for the worst and most degraded, for the outcast, the serpent-bitten and " +
                                   "the dying, a means of unlimited deliverance and uplifting.",
                        CreatedDate = DateTime.Parse("2019/02/26 18:37:58"),
                        ModifiedDate = DateTime.Parse("2019/02/26 18:37:58")
                    },

                    new ScriptureRecord
                    {
                        Book = "2 Peter",
                        Chapter = 1,
                        Verse = 21,
                        Comments = "Prophecy is but a lamp shining in a dark place; it is not the day-star. Prophecy came not by the will " +
                                   "of man; the prophets were moved or borne on by the Holy Ghost.",
                        CreatedDate = DateTime.Parse("2010/05/26 18:37:58"),
                        ModifiedDate = DateTime.Parse("2020/02/01 18:37:58")
                    },

                    new ScriptureRecord
                    {
                        Book = "2 Timothy",
                        Chapter = 3,
                        Verse = 16,
                        Comments = "It was by these writings, St. Paul would remind him, that he must test his teaching. On the way in " +
                                   "which \"inspiration of God\" was understood in the Church of the first days",
                        CreatedDate = DateTime.Parse("2017/11/13 18:37:58"),
                        ModifiedDate = DateTime.Parse("2017/11/14 18:37:58")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}