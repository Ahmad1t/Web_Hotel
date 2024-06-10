using BLL.DTO;
using BLL.Service._Generic;
using BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Book
{
    public interface IBookService : IGenericService<Bookdto>
    {
        ApiResponse<Bookdto> GetBook(int id);
    }
}