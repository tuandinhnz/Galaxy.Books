using Galaxy.Books.Domains;
using Microsoft.EntityFrameworkCore;

namespace Galaxy.Books.DataLayer
{
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PriceOffer> PriceOffers { get; set; }
        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>() 
                .HasKey(x => new {x.BookId, x.AuthorId});
        } 
    }
}
