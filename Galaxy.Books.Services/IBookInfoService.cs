using Galaxy.Books.Domains;

namespace Galaxy.Books.Services
{
    public interface IBookInfoService
    {
        Book GetBookByTitle(string title);
    }
}
