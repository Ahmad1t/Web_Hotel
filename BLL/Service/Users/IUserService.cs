using BLL.DTO;
using BLL.Service._Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Users
{
    public interface IUserService : IGenericService<Userdto>
    {
        bool login(string userName, string password);
        bool login(LoginRequestDto loginRequestDto);
    }
}
