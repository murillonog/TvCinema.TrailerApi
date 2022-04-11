using AutoMapper;
using TvCinema.TrailerApi.Service.Application.DTOs;
using TvCinema.TrailerApi.Service.Domain.Entities;

namespace TvCinema.TrailerApi.Service.CrossCutting.Mapping
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Trailers, TrailersDto>().ReverseMap();
        }
    }
}
