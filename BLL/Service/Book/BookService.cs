using AutoMapper;
using BLL.DTO;
using BLL.Service._Generic;
using BLL.Wrapping;
using DAL.Models;
using DAL.Repositories.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Book
{
    public class BookService : GenericService<Booking, Bookdto>, IBookService
    {
        public IBookRepo _BookRepo;
        public IMapper _Mapper;
        public BookService(IBookRepo bookRepo, IMapper mapper) : base(bookRepo, mapper)
        {
            _BookRepo = bookRepo;
            _Mapper = mapper;
        }

        public ApiResponse<Bookdto> GetBook(int id)
        {
            throw new NotImplementedException();
        }
    }
}
