using Microsoft.Extensions.DependencyInjection;
using TvCinema.TrailerApi.Service.Domain.Interfaces;
using TvCinema.TrailerApi.Service.Infrastructure.Repositories;

namespace TvCinema.TrailerApi.Service.CrossCutting.IoC
{
    public static class RepositoryConfig
    {
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<ITrailerRepository, TrailerRepository>();
        }
    }
}
