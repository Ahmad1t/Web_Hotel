using BLL.Service._Generic;
using BLL.Service.Auth;
using BLL.Service.Book;
using BLL.Service.CityWCountry;
using BLL.Service.Customer;
using BLL.Service.FloorWFloorRoom;
using BLL.Service.Users;
using DAL.Repositories.Floors;

namespace Web_Hotel.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddService(this IServiceCollection service)
        {
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IAuthService, AuthService>();
            service.AddScoped<IBookService, BookService>();

            service.AddScoped<ICityWCountryService, CityWCountryService>();

            service.AddScoped<IFloorWFloorRoomSerive, FloorWFloorRoomService>();

            return service;
        }
    }
}
