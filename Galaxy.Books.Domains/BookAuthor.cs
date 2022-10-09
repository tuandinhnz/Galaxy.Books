namespace Galaxy.Books.Domains
{
#nullable disable
    public class BookAuthor
    {
        //-----------------------------------------------
        //foreign keys
        public Guid BookId { get; set; }
        public Guid AuthorId { get; set; }
        
        public int Order { get; set; }

        //-----------------------------------------------
        //relationships
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
