using AutoMapper;
using BLL.DTO;
using BLL.Service._Generic;
using BLL.Wrapping;
using DAL.Models;
using DAL.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Users
{
    public class UserService : GenericService<User, Userdto> , IUserService
    {
        public readonly IUserRepo _repository;
        public readonly IMapper _mapper;

        public UserService(IUserRepo repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

/*        public override ApiResponse<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override ApiResponse<bool> Delete(Userdto id)
        {
            throw new NotImplementedException();
        }*/

        public bool login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public bool login(LoginRequestDto loginRequestDto)
        {
            //get user from database based on username
            var username = loginRequestDto.UserName;
            var user = _repository.GetUserByUsername(username);
            if (user != null)
            {
                return user.UserPassword == loginRequestDto.Password;
            }
            else
            {
                return false;
            }
        }
    }
}
