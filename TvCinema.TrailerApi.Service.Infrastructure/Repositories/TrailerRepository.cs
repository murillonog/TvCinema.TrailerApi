using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvCinema.TrailerApi.Service.Domain.Entities;
using TvCinema.TrailerApi.Service.Domain.Interfaces;
using TvCinema.TrailerApi.Service.Infrastructure.Context;

namespace TvCinema.TrailerApi.Service.Infrastructure.Repositories
{
    public class TrailerRepository : ITrailerRepository
    {
        protected ApplicationDbContext Db;
        protected DbSet<Trailers> DbSet;
        public TrailerRepository(ApplicationDbContext context)
        {
            Db = context;
            DbSet = Db.Set<Trailers>();
        }
        public async Task<Trailers?> GetByImdbId(string imdbId)
        {
            return await DbSet
                .FirstOrDefaultAsync(x => x.ImdbId == imdbId);
        }
    }
}
