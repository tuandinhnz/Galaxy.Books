using Galaxy.Books.Domains;
using Galaxy.Books.Services;
using Microsoft.AspNetCore.Mvc;

namespace Galaxy.Books.RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookInfoController : ControllerBase
    {
        private readonly IBookInfoService _bookInfoService;

        public BookInfoController(IBookInfoService bookInfoService)
        {
            _bookInfoService = bookInfoService;
        }

        [HttpGet]
        public Book Get([FromQuery]string title)
        {
            return _bookInfoService.GetBookByTitle(title);
        }
    }
}
