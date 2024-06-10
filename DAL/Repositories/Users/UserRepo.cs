using DAL.Models;
using DAL.Repositories._Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.Repositories.Users.UserRepo;

namespace DAL.Repositories.Users
{
    public class UserRepo : GenericRepository<User>, IUserRepo
    {
            public UserRepo(HotelContext HotelContext) : base(HotelContext) // base=super
            {

            }

            public User GetUserByUsername(string username)
            {
                return _dbSet.Where(x => x.UserName == username).FirstOrDefault();
            }
        
    }
}
