using CIT365_SacramentProgram.Data;
using CIT365_SacramentProgram.Models;
using System;
using System.Linq;


namespace CIT365_SacramentProgram.Data
{
    public class DbInitializer
    {
        public static void Initialize(SacramentContext context)
        {
            context.Database.EnsureCreated();

            if (context.Meeting.Any())
            {
                return;
            }

            var Meetings = new Meeting[]
            {
                new Meeting {
                    MeetingDate = DateTime.Parse("2020-04-18"),
                    Theme = "Atonement",
                    Presiding = "Bob Baskin",
                    Conducting = "Bob Baskin",
                    Director = "Jill Jacobs",
                    Organist = "Chris Waltz",
                    Invocation = "Xavier Jimenez",
                    OpeningHymnNumber = 308,
                    OpeningHymnDescription = "Now Let Us Rejoice",
                    SacramentHymnNumber = 875,
                    SacramentHymnDescription = "I Stand All Amazed",
                    IntermediateMusic = "Primary Performance",
                    ClosingHymnNumber = 302,
                    ClosingHymnDescription = "Lord, I would Follow Thee",
                    Benediction = "Carmen Jimenez",
                    Speakers = new Speaker[]
                    {
                        new Speaker
                        {
                            FullName = "Cody Carson",
                            Topic = "Christ Died for our Sins",
                            Type = SpeakerType.Adult
                        },
                        new Speaker
                        {
                            FullName = "Brianna Bellamy",
                            Topic = "Applying the Atonement",
                            Type = SpeakerType.Adult
                        },
                        new Speaker
                        {
                            FullName = "Dianna Downs",
                            Topic = "Forgiveness",
                            Type = SpeakerType.Youth
                        }
                    }
                },
                new Meeting {
                    MeetingDate = DateTime.Parse("2020-04-25"),
                    Theme = "Sabbath",
                    Presiding = "Bob Baskin",
                    Conducting = "Nick Nonce",
                    Director = "Jill Jacobs",
                    Organist = "Chris Waltz",
                    Invocation = "Eve Edmonton",
                    OpeningHymnNumber = 308,
                    OpeningHymnDescription = "Now Let Us Rejoice",
                    SacramentHymnNumber = 875,
                    SacramentHymnDescription = "I Stand All Amazed",
                    ClosingHymnNumber = 302,
                    ClosingHymnDescription = "Lord, I would Follow Thee",
                    Benediction = "Frank Gomez",
                    Speakers = new Speaker[]
                    {
                        new Speaker
                        {
                            FullName = "Mary Contrary",
                            Topic = "The Lord's Day",
                            Type = SpeakerType.Adult
                        },
                        new Speaker
                        {
                            FullName = "Guy Petersen",
                            Topic = "Keeping the Sabbath",
                            Type = SpeakerType.Adult
                        }
                    }
                },
                new Meeting {
                    MeetingDate = DateTime.Parse("2020-05-2"),
                    Theme = "Charity",
                    Presiding = "Bob Baskin",
                    Conducting = "Peter Blunt",
                    Director = "Jill Jacobs",
                    Organist = "Chris Waltz",
                    Invocation = "Harrison Hunt",
                    OpeningHymnNumber = 308,
                    OpeningHymnDescription = "Now Let Us Rejoice",
                    SacramentHymnNumber = 875,
                    SacramentHymnDescription = "I Stand All Amazed",
                    ClosingHymnNumber = 302,
                    ClosingHymnDescription = "Lord, I would Follow Thee",
                    Benediction = "Ida Moskowitz",
                    Speakers = new Speaker[]
                    {
                        new Speaker
                        {
                            FullName = "Kent Cole",
                            Topic = "Christ-like Love",
                            Type = SpeakerType.Adult
                        },
                        new Speaker
                        {
                            FullName = "Rusty Jackson",
                            Topic = "Developing Virtues",
                            Type = SpeakerType.Adult
                        }
                    }
                }
            };

            foreach (Meeting m in Meetings)
            {
                context.Meeting.Add(m);
            }
            context.SaveChanges();
        }
    }
}
