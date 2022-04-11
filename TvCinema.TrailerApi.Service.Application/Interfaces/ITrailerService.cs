using TvCinema.TrailerApi.Service.Application.DTOs;

namespace TvCinema.TrailerApi.Service.Application.Interfaces
{
    public interface ITrailerService
    {
        Task<TrailersDto> GetByImdbId(string imdbId);
    }
}
