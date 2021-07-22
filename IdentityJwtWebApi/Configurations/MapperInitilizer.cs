using AutoMapper;
using IdentityJwtWebApi.Data;
using IdentityJwtWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityJwtWebApi.Configurations
{
	public class MapperInitializer : Profile
	{
		public MapperInitializer()
		{
			//CreateMap<Country, CountryDTO>().ReverseMap();
			//CreateMap<Country, CreateCountryDTO>().ReverseMap();
			//CreateMap<Country, UpdateCountryDTO>().ReverseMap();
			//CreateMap<Hotel, HotelDTO>().ReverseMap();
			//CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
			//CreateMap<Hotel, UpdateHotelDTO>().ReverseMap();
			CreateMap<ApiUser, UserDTO>().ReverseMap();
		}
	}
}
