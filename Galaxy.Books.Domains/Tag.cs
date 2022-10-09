namespace Galaxy.Books.Domains
{
#nullable disable
    public class Tag
    {
        public Guid TagId { get; set; }
        public Genre Genre { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
