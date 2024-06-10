using BLL.DTO;
using BLL.Service.CityWCountry;
using BLL.Service.Users;
using BLL.Wrapping;
using Microsoft.AspNetCore.Mvc;

namespace Web_Hotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CityWCountryController 
    {
        public readonly ICityWCountryService _cityWCountryService;

        public CityWCountryController(ICityWCountryService cityWCountryService)
        {
            _cityWCountryService = cityWCountryService;
        }
        [HttpPost("AddCityAndCountry")]
        public  ApiResponse<CityWCountrydto> CityAndCountry(CityWCountrydto dto)
        {
            var result =  _cityWCountryService.CityAndCountry(dto);
            return result;
        }
    }
}