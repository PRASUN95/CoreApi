using CoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _IbookService;
        public BooksController(IBookService bookService)
        {
            _IbookService = bookService;
        }

        [HttpGet("{Id}")]
        public ActionResult Get(int Id)
        {
            return Ok(_IbookService.GetById(Id));
        }
    }
}
