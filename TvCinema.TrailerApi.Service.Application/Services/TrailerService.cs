using AutoMapper;
using Microsoft.Extensions.Logging;
using TvCinema.TrailerApi.Service.Application.DTOs;
using TvCinema.TrailerApi.Service.Application.Interfaces;
using TvCinema.TrailerApi.Service.Domain.Interfaces;

namespace TvCinema.TrailerApi.Service.Application.Services
{
    public class TrailerService : ITrailerService
    {
        private readonly ILogger<TrailerService> _logger;
        private readonly IMapper _mapper;
        private readonly ITrailerRepository _trailerRepository;

        public TrailerService(
            ILogger<TrailerService> logger, 
            IMapper mapper, 
            ITrailerRepository trailerRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _trailerRepository = trailerRepository;
        }

        public async Task<TrailersDto> GetByImdbId(string imdbId)
        {
            try
            {
                return _mapper.Map<TrailersDto>(await _trailerRepository.GetByImdbId(imdbId));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                throw;
            }
        }
    }
}
