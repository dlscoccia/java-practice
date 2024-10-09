using AutoMapper;
using dotnet_backend_basics.DTOs;
using dotnet_backend_basics.Models;

namespace dotnet_backend_basics.Automappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<BeerInsertDto, Beer>();
            CreateMap<Beer, BeerDto>().ForMember(dto => dto.Id, m => m.MapFrom(b => b.BeerID));
            CreateMap<BeerUpdateDto, Beer>();
        }
    }
}
