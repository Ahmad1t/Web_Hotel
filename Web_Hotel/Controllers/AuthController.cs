using BLL.DTO;
using BLL.Service.Auth;
using BLL.Wrapping;
using Microsoft.AspNetCore.Mvc;

namespace Web_Hotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("login")]
        public ApiResponse<bool> login(LoginRequestDto loginRequest)
        {
            return _authService.Login(loginRequest.UserName,loginRequest.Password);
        }
    }
}
