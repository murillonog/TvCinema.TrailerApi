using Microsoft.AspNetCore.Mvc;
using TvCinema.TrailerApi.Service.Application.DTOs;
using TvCinema.TrailerApi.Service.Application.Interfaces;

namespace TvCinema.TrailerApi.Service.Api.Controllers
{
    [ApiController]
    [Route("api/rating")]
    public class TrailerController : ControllerBase
    {
        private readonly ITrailerService _trailerService;

        public TrailerController(ITrailerService trailerService)
        {
            _trailerService = trailerService;
        }

        [HttpGet("{imdbId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TrailersDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(List<string>))]
        public async Task<IActionResult> Get(string imdbId)
        {
            try
            {
                var result = await _trailerService.GetByImdbId(imdbId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message, null, null, null, null);
            }
        }
    }
}
