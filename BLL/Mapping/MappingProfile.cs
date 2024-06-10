/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using DAL.Models;
using AutoMapper;
using BLL.DTO;
using AutoMapper.Configuration;
namespace BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, Userdto>().ReverseMap();
            CreateMap<Booking,Bookdto>().ReverseMap();

            CreateMap<City, Citydto>().ReverseMap();   
            CreateMap<Country, Countrydto>().ReverseMap();
            CreateMap<Countrydto, CityWCountrydto>().ReverseMap();
            CreateMap<Citydto, CityWCountrydto>().ReverseMap();

            CreateMap<CityWCountrydto, City>().ReverseMap();

            CreateMap<Floor, Floordto>().ReverseMap();
            CreateMap<FloorRoom , FloorRoomdto>().ReverseMap();
            CreateMap<Floor, FloorWFloorRoomdto>().ReverseMap();
            CreateMap<FloorRoom, FloorWFloorRoomdto>().ReverseMap();
        }
    }
}
