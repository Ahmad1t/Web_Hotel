using BLL.Service.CityWCountry;
using DAL.Repositories.Books;
using DAL.Repositories.Cities;
using DAL.Repositories.Countries;
using DAL.Repositories.Customers;
using DAL.Repositories.FloorRooms;
using DAL.Repositories.Floors;
using DAL.Repositories.Users;

namespace Web_Hotel.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepository(this IServiceCollection service)
        {
            service.AddScoped<ICustomerRepositry, CustomerRepositry>();
            service.AddScoped<IUserRepo, UserRepo>();
            service.AddScoped<IBookRepo, BookRepo>();

            service.AddScoped<ICityRepo, CityRepo>();
            service.AddScoped<ICountryRepo, CountryRepo>();

            service.AddScoped<IFloorRepo, FloorRepo>();
            service.AddScoped<IFloorRoomRepo, FloorRoomRepo>();
            return service;
        }
    }
}
