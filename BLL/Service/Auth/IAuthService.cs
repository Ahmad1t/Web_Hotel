using BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Wrapping;

namespace BLL.Service.Auth
{
    public interface IAuthService
    {
        ApiResponse<bool> Login(string username, string password);
    }
}
