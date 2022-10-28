using Galaxy.Books.Domains;
using Galaxy.Books.Services.Repositories;

namespace Galaxy.Books.Services
{
    public class BookInfoService : IBookInfoService
    {
        private readonly IBookInfoRepository _bookInfoRepository;

        public BookInfoService(IBookInfoRepository bookInfoRepository)
        {
            _bookInfoRepository = bookInfoRepository;
        }

        public Book GetBookByTitle(string title)
        {
            return _bookInfoRepository.GetBookByTitle(title);
        }
    }
}
