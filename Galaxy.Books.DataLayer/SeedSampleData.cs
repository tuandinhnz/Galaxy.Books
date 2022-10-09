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
                await context.Database.ExecuteSqlRawAsync("DELETE FROM [dbo].[Books]");
            }
            
            List<Book> books = new List<Book>
            {
                new()
                {
                    BookId = Guid.NewGuid(),
                    Title = "A Promised Land",
                    Description =
                        "A Promised Land is a memoir by Barack Obama, the 44th president of the United States from 2009 to 2017. Published on November 17, 2020, it is the first of a planned two-volume series",
                    PublishedOn = new DateTime(2020, 11, 17),
                    Publisher = "Crown",
                    Price = 9.12m,
                    ImageUrl = "Not available"
                },
                new()
                {
                    BookId = Guid.NewGuid(),
                    Title = "Jane Eyre",
                    Description =
                        "Jane Eyre is a novel by the English writer Charlotte Brontë. It was published under her pen name \"Currer Bell\" on 19 October 1847 by Smith, Elder & Co. of London. The first American edition was published the following year by Harper & Brothers of New York.",
                    PublishedOn = new DateTime(2003, 02, 04),
                    Publisher = "Penguin",
                    Price = 6.5m,
                    ImageUrl = "Not available"
                },
                new()
                {
                    BookId = Guid.NewGuid(),
                    Title = "The Martian",
                    Description =
                        "The Martian is a 2011 science fiction debut novel written by Andy Weir. The book was originally self-published on Weir's blog, in a serialized format. In 2014, the book was re-released after Crown Publishing Group purchased the exclusive publishing rights.",
                    PublishedOn = new DateTime(2011, 05, 05),
                    Publisher = "Crown",
                    Price = 8.2m,
                    ImageUrl = "Not available"
                },
                new()
                {
                    BookId = Guid.NewGuid(),
                    Title = "The Fellowship of the Ring",
                    Description = "The Fellowship of the Ring is the first of three volumes of the epic novel The Lord of the Rings by the English author J. R. R. Tolkien. It is followed by The Two Towers and The Return of the King.",
                    PublishedOn = new DateTime(1954, 07, 29),
                    Publisher = "William Morrow",
                    Price = 11.99m,
                    ImageUrl = "Not available"
                },
                new()
                {
                    BookId = Guid.NewGuid(),
                    Title = "The Hobbit",
                    Description = "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published in 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction.",
                    PublishedOn = new DateTime(1937, 09, 21),
                    Publisher = "Houghton Mifflin Harcourt",
                    Price = 11.91m,
                    ImageUrl = "Not available"
                }
            };
            
            await context.Books.AddRangeAsync(books);
            await context.SaveChangesAsync();
        } 
    }
}
