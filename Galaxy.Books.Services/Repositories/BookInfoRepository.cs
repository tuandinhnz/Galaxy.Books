using Galaxy.Books.DataLayer;
using Galaxy.Books.Domains;

namespace Galaxy.Books.Services.Repositories
{
    public class BookInfoRepository : IBookInfoRepository
    {
        private readonly BooksDbContext _booksDbContext;

        public BookInfoRepository(BooksDbContext booksDbContext)
        {
            _booksDbContext = booksDbContext;
        }

        public Book GetBookByTitle(string title)
        {
            return _booksDbContext.Books.SingleOrDefault(book => book.Title == title);
        }
    }
}
