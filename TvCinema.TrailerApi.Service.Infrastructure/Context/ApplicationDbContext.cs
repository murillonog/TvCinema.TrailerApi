using Microsoft.EntityFrameworkCore;
using TvCinema.TrailerApi.Service.Domain.Entities;

namespace TvCinema.TrailerApi.Service.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        public DbSet<Trailers> Trailers { get; set; }
    }
}
