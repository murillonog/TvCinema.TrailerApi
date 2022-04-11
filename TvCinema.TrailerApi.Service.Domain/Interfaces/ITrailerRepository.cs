using TvCinema.TrailerApi.Service.Domain.Entities;

namespace TvCinema.TrailerApi.Service.Domain.Interfaces
{
    public interface ITrailerRepository
    {
        Task<Trailers?> GetByImdbId(string imdbId);
    }
}
