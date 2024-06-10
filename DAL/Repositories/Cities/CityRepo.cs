using DAL.Models;
using DAL.Repositories._Generics;
using DAL.Repositories.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Cities
{
    public class CityRepo : GenericRepository<City> , ICityRepo
    {
        public CityRepo(HotelContext HotelContext) : base(HotelContext)
        {

        }
    }
}