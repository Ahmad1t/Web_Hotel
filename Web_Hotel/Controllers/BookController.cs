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
       /* [HttpGet("GetAll")]
        public ApiResponse<IEnumerable<Bookdto>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("GetById")]
        public ApiResponse<Bookdto> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost("Add")]
        public ApiResponse<Bookdto> Add(Bookdto dto)
        {
            return _service.Add(dto);
        }

        [HttpPut("Update")]
        public ApiResponse<Bookdto> Update(Bookdto dto)
        {
            return _service.Update(dto);
        }

        [HttpDelete("DeleteById")]
        public ApiResponse<bool> DeleteById(int id)
        {
            return _service.Delete(id);
        }

        [HttpDelete("Delete")]
        public ApiResponse<bool> Delete(Bookdto dto)
        {
            return _service.Delete(dto);
        }*/
    }
}
