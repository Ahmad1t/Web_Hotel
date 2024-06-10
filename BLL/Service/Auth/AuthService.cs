using BLL.Wrapping;
using DAL.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepo _userRepo;

        public AuthService(IUserRepo userRepo) 
        {
            _userRepo = userRepo;
        }

        public ApiResponse<bool> Login(string username, string password)
        {
            var user = _userRepo.GetUserByUsername(username);
            if (user == null)
            {
                throw new Exception("wrong user");
            }
            if (password == null)
            {
                throw new Exception("pass wrong");
            }
            return new ApiResponse<bool>(true);
        }
    }
}
