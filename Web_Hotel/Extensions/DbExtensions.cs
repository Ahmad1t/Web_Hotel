using DAL.Models;
using Microsoft.EntityFrameworkCore;
namespace Web_Hotel.Extensions
{
    public static class DbExtensions
    {
        public static IServiceCollection AddDb(this IServiceCollection service, ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");


            service.AddDbContext<HotelContext>(options =>
                  options.UseSqlServer(ConnectionString)
                  );
            return service;
        }
    }
}
