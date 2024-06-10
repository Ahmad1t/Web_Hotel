using AutoMapper;
using BLL.DTO;
using BLL.Wrapping;
using DAL.Models;
using DAL.Repositories.Cities;
using DAL.Repositories.Countries;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BLL.Service.CityWCountry
{
    public class CityWCountryService : ICityWCountryService
    {
        public readonly ICityRepo _cityRepo;
        public readonly ICountryRepo _countryRepo;
        public readonly IMapper _mapper;

        public CityWCountryService(ICityRepo cityRepo, ICountryRepo countryRepo, IMapper mapper)
        {
            _countryRepo = countryRepo;
            _cityRepo = cityRepo;
            _mapper = mapper;
        }


        public ApiResponse<CityWCountrydto> CityAndCountry(CityWCountrydto dto)
        {
            ApiResponse<CityWCountrydto> responseobj = new ApiResponse<CityWCountrydto>();

            using (var transaction = new TransactionScope(TransactionScopeOption.Required,
                new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted },
                TransactionScopeAsyncFlowOption.Enabled)) 
            {
                try
                {
                    var CountryValue = new Countrydto();
                    CountryValue = _mapper.Map<Countrydto>(dto);
                    _countryRepo.Add(_mapper.Map<Country>(CountryValue));

                    var CityRequest = _mapper.Map<City>(dto);
                    CityRequest.CountryId = CountryValue.CountryId;

                    _cityRepo.Add(CityRequest);

                    transaction.Complete();

                    responseobj.Data = dto;

                    return responseobj;
                }
                catch (Exception ex)
                {
                    transaction.Dispose();
                    throw;
                }
            }
        }

    }
}
/*var CityValue = new Citydto();
CityValue.CountryId = CountryValue.CountryId;

CityValue = _mapper.Map<Citydto>(dto);
_cityRepo.Add(_mapper.Map<City>(CityValue));
                    responseobj.Data = _mapper.Map<CityWCountrydto>(CountryValue);
                    responseobj.Data = _mapper.Map<CityWCountrydto>(CityValue);*/