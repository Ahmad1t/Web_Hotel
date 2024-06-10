using DAL.Models;
using DAL.Repositories._Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Countries
{
    public interface ICountryRepo : IGenericRepo<Country>
    {

    }
}
