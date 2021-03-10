using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using EdFlix.Models;

namespace EdFlix_abstraction
{
    public interface IMoviesRepository
    {
        IEnumerable<Movie> GetMovies();
        IEnumerable<EnumModel> GetGenres();
    }
}