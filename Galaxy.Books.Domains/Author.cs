namespace Galaxy.Books.Domains
{
#nullable disable
    public class Author
    {
        public const int NameLength = 100;

        public Guid AuthorId { get; set; }
        public string Name { get; set; }

        //------------------------------
        //Relationships

        public ICollection<BookAuthor> BooksLink { get; set; }
    }
}
