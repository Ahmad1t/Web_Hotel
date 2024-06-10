using BLL.DTO;
using BLL.Service.Book;
using BLL.DTO;
using BLL.Wrapping;
using Microsoft.AspNetCore.Mvc;

namespace Web_Hotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : _GenericController<Bookdto>
    {
        public readonly IBookService _BookService;

        public BookController(IBookService bookService) : base(bookService)
        {
            _BookService = bookService;
        }
     
    }
}
