using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using EdFlix.Models;
using EdFlix_abstraction;

namespace EdFlix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly IMoviesRepository _repository;

        public MoviesController(ILogger<MoviesController> logger, IMoviesRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {  
            var movies = _repository.GetMovies();

            return Ok(movies);
        }

        [HttpGet]
        [Route("genres")]
        public ActionResult<IEnumerable<Movie>> GetGenres()
        {  
            var genres = _repository.GetGenres();

            return Ok(genres);
        }
    }
}
