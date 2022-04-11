using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TvCinema.TrailerApi.Service.Infrastructure.Context;

namespace TvCinema.TrailerApi.Service.CrossCutting.IoC
{
    public static class DataBaseConfig
    {
        public static void ConfigureDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("ConnectionTrailers")));
        }
    }
}
