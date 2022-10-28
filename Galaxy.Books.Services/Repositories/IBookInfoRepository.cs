using Galaxy.Books.Domains;

namespace Galaxy.Books.Services.Repositories
{
    public interface IBookInfoRepository
    {
        Book GetBookByTitle(string title);
    }
}
