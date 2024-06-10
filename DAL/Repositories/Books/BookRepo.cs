using DAL.Models;
using DAL.Repositories._Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Books
{
    public class BookRepo : GenericRepository<Booking>  , IBookRepo
    {
        public BookRepo(HotelContext HotelContext) : base(HotelContext) // base=super
        {

        }
    }
}
