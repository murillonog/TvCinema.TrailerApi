using Microsoft.Extensions.DependencyInjection;
using TvCinema.TrailerApi.Service.Application.Interfaces;
using TvCinema.TrailerApi.Service.Application.Services;

namespace TvCinema.TrailerApi.Service.CrossCutting.IoC
{
    public static class ServiceConfig
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ITrailerService, TrailerService>();
        }
    }
}
