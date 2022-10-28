using Galaxy.Books.Domains;
using Microsoft.EntityFrameworkCore;

namespace Galaxy.Books.DataLayer
{
    public static class SeedSampleData
    {
        public static async Task SeedData(BooksDbContext context)
        {
            if (context.Books.Any())
            {
                //return;
                await context.Database.ExecuteSqlRawAsync(@"DELETE FROM [dbo].[Books] 
                                                            DELETE FROM [dbo].[Authors] 
                                                            DELETE FROM [dbo].[BookAuthor] 
                                                            DELETE FROM [dbo].[Review]");
            }

            var barrackObama = new Author
            {
                Name = "Barack Obama"
            };

            var charlotteBronte = new Author
            {
                Name = "Charlotte Brontë"
            };

            var andyWeir = new Author
            {
                Name = "Andy Weir"
            };
            
            var tolkien = new Author
            {
                Name = "J. R. R. Tolkien"
            };

            var kleppmann = new Author
            {
                Name = "Kleppmann"
            };

            var josephAlbahari = new Author
            {
                Name = "Joseph Albahari"
            };

            var shakespeare = new Author
            {
                Name = "William Shakespeare"
            };

            var aldousHuxley = new Author
            {
                Name = "Aldous Huxley"
            };

            var colleenHoover = new Author
            {
                Name = "Colleen Hoover"
            };

            var autobiography = new Tag
            {
                Genre = Genre.Autobiography
            };
            
            var novel = new Tag
            {
                Genre = Genre.Novel
            };

            
            List<Book> books = new List<Book>
            {
                new()
                {
                    Title = "A Promised Land",
                    Description =
                        "A Promised Land is a memoir by Barack Obama, the 44th president of the United States from 2009 to 2017. Published on November 17, 2020, it is the first of a planned two-volume series",
                    PublishedOn = new DateTime(2020, 11, 17),
                    Publisher = "Crown",
                    Price = 9.12m,
                    ImageUrl = "Not available",
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            NumStars = 4,
                            Comment = "Great Test Book",
                            VoterName = "Mr U Test"
                        },
                        new()
                        {
                            NumStars = 3,
                            Comment = "No so good",
                            VoterName = "Mr Stranger"
                        },
                        new()
                        {
                            NumStars = 5,
                            Comment = "Inspiring",
                            VoterName = "Mrs Fanning"
                        }
                    },
                    AuthorsLink = new List<BookAuthor>
                    {
                        new ()
                        {
                            Order = 1,
                            Author = barrackObama
                        }
                    }
                },
                new()
                {
                    Title = "Jane Eyre",
                    Description =
                        "Jane Eyre is a novel by the English writer Charlotte Brontë. It was published under her pen name \"Currer Bell\" on 19 October 1847 by Smith, Elder & Co. of London. The first American edition was published the following year by Harper & Brothers of New York.",
                    PublishedOn = new DateTime(2003, 02, 04),
                    Publisher = "Penguin",
                    Price = 6.5m,
                    ImageUrl = "Not available",
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            NumStars = 5,
                            Comment = "I love this classic book",
                            VoterName = "Alex"
                        }
                    },
                    AuthorsLink = new List<BookAuthor>
                    {
                        new ()
                        {
                            Order = 1,
                            Author = charlotteBronte
                        }
                    }
                },
                new()
                {
                    Title = "The Martian",
                    Description =
                        "The Martian is a 2011 science fiction debut novel written by Andy Weir. The book was originally self-published on Weir's blog, in a serialized format. In 2014, the book was re-released after Crown Publishing Group purchased the exclusive publishing rights.",
                    PublishedOn = new DateTime(2011, 05, 05),
                    Publisher = "Crown",
                    Price = 8.2m,
                    ImageUrl = "Not available",
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            NumStars = 5,
                            Comment = "A great science-fiction book. Must read.",
                            VoterName = "Julian"
                        }
                    },
                    AuthorsLink = new List<BookAuthor>
                    {
                        new ()
                        {
                            Order = 1,
                            Author = andyWeir
                        }
                    }
                },
                new()
                {
                    Title = "The Fellowship of the Ring",
                    Description = "The Fellowship of the Ring is the first of three volumes of the epic novel The Lord of the Rings by the English author J. R. R. Tolkien. It is followed by The Two Towers and The Return of the King.",
                    PublishedOn = new DateTime(1954, 07, 29),
                    Publisher = "William Morrow",
                    Price = 11.99m,
                    ImageUrl = "Not available",
                    AuthorsLink = new List<BookAuthor>
                    {
                        new ()
                        {
                            Order = 1,
                            Author = tolkien
                        }
                    }
                },
                new()
                {
                    Title = "The Hobbit",
                    Description = "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published in 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction.",
                    PublishedOn = new DateTime(1937, 09, 21),
                    Publisher = "Houghton Mifflin Harcourt",
                    Price = 11.91m,
                    ImageUrl = "Not available",
                    AuthorsLink = new List<BookAuthor>
                    {
                        new ()
                        {
                            Order = 1,
                            Author = tolkien
                        }
                    }
                },
                new()
                {
                    Title = "Designing Data-Intensive Applications",
                    Description = "In this practical and comprehensive guide, author Martin Kleppmann helps you navigate this diverse landscape by examining the pros and cons of various technologies for processing and storing data. Software keeps changing, but the fundamental principles remain the same.",
                    PublishedOn = new DateTime(2017, 03, 20),
                    Publisher = "O'Reilly Media, Inc",
                    Price = 13.50m,
                    ImageUrl = "Not available",
                    AuthorsLink = new List<BookAuthor>
                    {
                        new ()
                        {
                            Order = 1,
                            Author = kleppmann
                        }
                    }
                },
                new()
                {
                    Title = "C# In a Nutshell",
                    Description = "C# in a Nutshell provides everything programmers need to know about the C# language in one concise and accessible volume. Designed as a primary reference for daily use, it also includes all the essential background information to become productive quickly.",
                    PublishedOn = new DateTime(2022, 03, 15),
                    Publisher = "O'Reilly Media, Inc",
                    Price = 11.50m,
                    ImageUrl = "Not available",
                    AuthorsLink = new List<BookAuthor>
                    {
                        new ()
                        {
                            Order = 1,
                            Author = josephAlbahari
                        }
                    }
                },
                new()
                {
                    Title = "Hamlet",
                    Description = "The Tragedy of Hamlet, Prince of Denmark, often shortened to Hamlet, is a tragedy written by William Shakespeare sometime between 1599 and 1601. It is Shakespeare's longest play, with 29,551 words.",
                    PublishedOn = new DateTime(1992, 07, 01),
                    Publisher = "Simon & Schuster",
                    Price = 6.49m,
                    ImageUrl = "Not available",
                    AuthorsLink = new List<BookAuthor>
                    {
                        new ()
                        {
                            Order = 1,
                            Author = shakespeare
                        }
                    }
                },
                new()
                {
                    Title = "Brave New Work",
                    Description = "Brave New World is a dystopian novel by English author Aldous Huxley, written in 1931 and published in 1932.",
                    PublishedOn = new DateTime(1932, 05, 15),
                    Publisher = "Harper Perennial",
                    Price = 8.32m,
                    ImageUrl = "Not available",
                    AuthorsLink = new List<BookAuthor>
                    {
                        new ()
                        {
                            Order = 1,
                            Author = aldousHuxley
                        }
                    }
                },
                new()
                {
                    Title = "It Starts With Us",
                    Description = "Before It Ends with Us, it started with Atlas. Colleen Hoover tells fan favorite Atlas’s side of the story and shares what comes next in this long-anticipated sequel to the “glorious and touching”.",
                    PublishedOn = new DateTime(2022, 10, 10),
                    Publisher = "Atria Books",
                    Price = 18.54m,
                    ImageUrl = "Not available",
                    AuthorsLink = new List<BookAuthor>
                    {
                        new ()
                        {
                            Order = 1,
                            Author = colleenHoover
                        }
                    }
                }
            };
            await context.AddRangeAsync(books);
            await context.SaveChangesAsync();
        } 
    }
}
