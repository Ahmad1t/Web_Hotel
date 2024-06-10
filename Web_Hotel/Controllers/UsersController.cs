using BLL.DTO;
using BLL.Service.Users;
using BLL.Wrapping;
using Microsoft.AspNetCore.Mvc;

namespace Web_Hotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : _GenericController<Userdto>
    {
        private readonly IUserService _service;

        public UsersController(IUserService service) : base(service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public ApiResponse<bool> Login(LoginRequestDto loginRequest)
        {
            //return _service.login(loginRequest.Username, loginRequest.Password);
            var response = new ApiResponse<bool>();
            var result = _service.login(loginRequest);
            return response;
        }
    }
}