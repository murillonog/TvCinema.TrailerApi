using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TvCinema.TrailerApi.Service.CrossCutting.Mapping;

namespace TvCinema.TrailerApi.Service.CrossCutting.IoC
{
    public static class MappingConfig
    {
        public static void ConfigureMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DomainToDtoMappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
