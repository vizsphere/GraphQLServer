namespace GraphQLServer.Models
{
    public class ModelDataSeeder
    {
        private readonly ApplicationDbContext _context;
        public ModelDataSeeder(ApplicationDbContext context)
        {
            _context=context;
        }

        public async Task SeedAsync()
        {
            try
            {
                if (!_context.Speakers.Any())
                {
                    List<Speaker> speakers = new List<Speaker>()
                    {
                        new Speaker()
                        {
                            Name ="Dave Ramsey",
                            Bio = "David Ramsey is an American financial author, radio host, television personality, and motivational speaker. His show and writings strongly focus on encouraging people to get out of debt.",
                            WebSite = "http://www.daveramsey.com"
                        },
                        new Speaker()
                        {
                            Name ="Tony Robbins",
                            Bio = "Tony Robbins is an American motivational speaker, personal finance instructor, and self-help author. He became well known from his infomercials and self-help books: Unlimited Power, Unleash the Power Within and Awaken the Giant Within.",
                            WebSite = "http://www.tonyrobbins.com"
                        },
                        new Speaker()
                        {
                            Name ="Nick Vujicic",
                            Bio = "Nick Vujicic is an Australian Christian evangelist and top motivational speaker born with Phocomelia, a rare disorder characterised by the absence of legs and arms.",
                            WebSite = "http://www.nickvujicic.com"
                        },
                        new Speaker()
                        {
                            Name ="Eckhart Tolle",
                            Bio = "Eckhart Tolle is a German-born resident of Canada, best known as the author of The Power of Now and A New Earth: Awakening to your Life’s Purpose. In 2011, he was listed by Watkins Review as the most spiritually influential person in the world.",
                            WebSite = "http://www.eckharttolle.com"
                        },
                        new Speaker()
                        {
                            Name ="Louise Hay",
                            Bio = "Louise Lynn Hay was an American motivational author and the founder of Hay House, she authored several New Thought self-help books, including the 1984 book, You Can Heal Your Life. Louise Hay died on the morning of August 30, 2017 at age 90.",
                            WebSite = "http://www.louisehay.com"
                        },
                        new Speaker()
                        {
                            Name ="Chris Gardner",
                            Bio = "Chris Gardner is an American entrepreneur, investor, stockbroker, motivational speaker, author, and philanthropist who, during the early 1980s, struggled with homelessness while raising his toddler son. Gardner’s book of memoirs, The Pursuit of Happyness, was published in May 2006.",
                            WebSite = "http://www.chrisgardnermedia.com"
                        },
                        new Speaker()
                        {
                            Name ="Robert Kiyosaki",
                            Bio = "Robert Kiyosaki is an American businessman, investor, self-help author, educator, motivational speaker, financial literacy activist, financial commentator, and radio personality. Kiyosaki is the founder of the Rich Dad Company, who provide financial and business education to people through books, videos, games, seminars, blogs, coaching, and workshops.",
                            WebSite = "http://www.richdad.com"
                        },
                        new Speaker()
                        {
                            Name ="Eric Thomas",
                            Bio = "Eric Thomas is an American motivational speaker, author and minister. After becoming known as a motivational speaker, Thomas founded a company to offer education consulting, executive coaching and athletic development, including athletes such as Lebron James.",
                            WebSite = "http://www.etinspires.com"
                        },
                        new Speaker()
                        {
                            Name ="Les Brown",
                            Bio = "Leslie Brown is an American motivational speaker, author, radio DJ, former television host, and former politician as a member of the Ohio House of Representatives. As a motivational speaker, he uses the catch phrase “it’s possible!” and teaches people to follow their dreams as he learned to do.",
                            WebSite = "http://www.lesbrown.com"
                        },
                        new Speaker()
                        {
                            Name ="Suze Orman",
                            Bio = "Suze Orman is an American author, financial advisor, motivational speaker, and television host. In 1987, she founded the Suze Orman Financial Group. Her program The Suze Orman Show began airing on CNBC in 2002 and won a Gracie Award for Outstanding Program Host on CNBC for it. She has written several books on the topic of personal finance.",
                            WebSite = "http://www.suzeorman.com"
                        },
                    };
                    await _context.Speakers.AddRangeAsync(speakers);
                    await _context.SaveChangesAsync();
                }

                if (!_context.Attendees.Any())
                {
                    List<Attendee> attendees = new List<Attendee>()
                    {
                        new Attendee(){ FirstName = "Wade", LastName = "Harris", EmailAddress = "WadeWilliams@test.com", UserName ="WadeWilliams"},
                        new Attendee(){ FirstName = "Dave", LastName = "Thomas", EmailAddress = "DaveHarris@test.com", UserName ="DaveHarris"},
                        new Attendee(){ FirstName = "Seth", LastName = "Robinson", EmailAddress = "SethThomas@test.com", UserName ="SethThomas"},
                        new Attendee(){ FirstName = "Ivan", LastName = "Walker", EmailAddress = "IvanRobinson@test.com", UserName ="IvanRobinson"},
                        new Attendee(){ FirstName = "Riley", LastName = "Scott", EmailAddress = "RileyWalker@test.com", UserName ="RileyWalker"},
                        new Attendee(){ FirstName = "Gilbert", LastName = "Nelson", EmailAddress = "GilbertScott@test.com", UserName ="GilbertScott"},
                        new Attendee(){ FirstName = "Jorge", LastName = "Mitchell", EmailAddress = "JorgeNelson@test.com", UserName ="JorgeNelson"},
                        new Attendee(){ FirstName = "Dan", LastName = "Morgan", EmailAddress = "DanMitchell@test.com", UserName ="DanMitchell"},
                        new Attendee(){ FirstName = "Brian", LastName = "Cooper", EmailAddress = "BrianMorgan@test.com", UserName ="BrianMorgan"},
                        new Attendee(){ FirstName = "Roberto", LastName = "Howard", EmailAddress = "RobertoCooper@test.com", UserName ="RobertoCooper"},
                        new Attendee(){ FirstName = "Ramon", LastName = "Davis", EmailAddress = "RamonHoward@test.com", UserName ="RamonHoward"},
                        new Attendee(){ FirstName = "Miles", LastName = "Miller", EmailAddress = "MilesDavis@test.com", UserName ="MilesDavis"},
                        new Attendee(){ FirstName = "Liam", LastName = "Martin", EmailAddress = "LiamMiller@test.com", UserName ="LiamMiller"},
                        new Attendee(){ FirstName = "Nathaniel", LastName = "Smith", EmailAddress = "NathanielMartin@test.com", UserName ="NathanielMartin"},
                        new Attendee(){ FirstName = "Ethan", LastName = "Anderson", EmailAddress = "EthanSmith@test.com", UserName ="EthanSmith"},
                        new Attendee(){ FirstName = "Lewis", LastName = "White", EmailAddress = "LewisAnderson@test.com", UserName ="LewisAnderson"},
                        new Attendee(){ FirstName = "Milton", LastName = "Perry", EmailAddress = "MiltonWhite@test.com", UserName ="MiltonWhite"},
                        new Attendee(){ FirstName = "Claude", LastName = "Clark", EmailAddress = "ClaudePerry@test.com", UserName ="ClaudePerry"},
                        new Attendee(){ FirstName = "Joshua", LastName = "Richards", EmailAddress = "JoshuaClark@test.com", UserName ="JoshuaClark"},
                        new Attendee(){ FirstName = "Glen", LastName = "kings", EmailAddress = "Glen Richards@test.com", UserName ="GlenRichards"}
                    };
                    await _context.Attendees.AddRangeAsync(attendees);
                    await _context.SaveChangesAsync();
                }

                if (!_context.Tracks.Any())
                {
                    List<Track> tracks = new List<Track>(); 
                    for(int i = 1; i <= 20; i++)
                    {
                        tracks.Add(new Track()
                        {
                            Name = "Session-Track-" + i
                        }); 
                    }
                    await _context.Tracks.AddRangeAsync(tracks);
                    await _context.SaveChangesAsync();   
                } 
                
                if(!_context.Sessions.Any())
                {
                    List<Session> sessions = new List<Session>(); 
                    for(int i = 1; i<=20;i++)
                    {
                        sessions.Add(new Session()
                        {
                            Title = "Session - " + i,
                            Abstract = "Session - " + i,
                            StartTime = DateTime.Now.AddDays(i),
                            EndTime = DateTime.Now.AddDays(i + 5),
                            TrackId = i,
                        });
                    }
                    await _context.Sessions.AddRangeAsync(sessions);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

}
