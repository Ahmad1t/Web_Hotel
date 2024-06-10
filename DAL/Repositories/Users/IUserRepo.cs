using DAL.Models;
using DAL.Repositories._Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Users
{
    public interface IUserRepo : IGenericRepo<User>
    {
        User GetUserByUsername(string username);
    }
}
