using System;
using System.Linq;
using System.Collections.Generic;
using EdFlix_abstraction;
using EdFlix.Models;

namespace EdFlix_repository
{
    public class MoviesRepository : IMoviesRepository
    {
        public MoviesRepository()
        {

        }

        public IEnumerable<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Title = "Beetlejuice",
                    Year = 1988,
                    Runtime = 92,
                    Genre = Genre.Comedy,
                    Director = "Tim Burton",
                    Actors = "Alec Baldwin, Geena Davis, Annie McEnroe, Maurice Page",
                    Plot = "A couple of recently deceased ghosts contract the services of a \"bio-exorcist\" in order to remove the obnoxious new owners of their house.",
                    PosterUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTUwODE3MDE0MV5BMl5BanBnXkFtZTgwNTk1MjI4MzE@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Cotton Club",
                    Year = 1984,
                    Runtime = 127,
                    Genre = Genre.Crime,
                    Director = "Francis Ford Coppola",
                    Actors = "Richard Gere, Gregory Hines, Diane Lane, Lonette McKee",
                    Plot = "The Cotton Club was a famous night club in Harlem. The story follows the people that visited the club, those that ran it, and is peppered with the Jazz music that made it so famous.",
                    PosterUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTU5ODAyNzA4OV5BMl5BanBnXkFtZTcwNzYwNTIzNA@@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 3,
                    Title = "The Shawshank Redemption",
                    Year = 1994,
                    Runtime = 142,
                    Genre = Genre.Crime,
                    Director = "Frank Darabont",
                    Actors = "Tim Robbins, Morgan Freeman, Bob Gunton, William Sadler",
                    Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    PosterUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BODU4MjU4NjIwNl5BMl5BanBnXkFtZTgwMDU2MjEyMDE@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 4,
                    Title = "Crocodile Dundee",
                    Year = 1986,
                    Runtime = 97,
                    Genre = Genre.Adventure,
                    Director = "Peter Faiman",
                    Actors = "Paul Hogan, Linda Kozlowski, John Meillon, David Gulpilil",
                    Plot = "An American reporter goes to the Australian outback to meet an eccentric crocodile poacher and invites him to New York City.",
                    PosterUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTg0MTU1MTg4NF5BMl5BanBnXkFtZTgwMDgzNzYxMTE@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 5,
                    Title = "Valkyrie",
                    Year = 2008,
                    Runtime = 121,
                    Genre = Genre.Drama,
                    Director = "Bryan Singer",
                    Actors = "Tom Cruise, Kenneth Branagh, Bill Nighy, Tom Wilkinson",
                    Plot = "A dramatization of the 20 July assassination and political coup plot by desperate renegade German Army officers against Hitler during World War II.",
                    PosterUrl = "http://ia.media-imdb.com/images/M/MV5BMTg3Njc2ODEyN15BMl5BanBnXkFtZTcwNTAwMzc3NA@@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 6,
                    Title = "Ratatouille",
                    Year = 2007,
                    Runtime = 111,
                    Genre = Genre.Animation,
                    Director = "Brad Bird, Jan Pinkava",
                    Actors = "Patton Oswalt, Ian Holm, Lou Romano, Brian Dennehy",
                    Plot = "A rat who can cook makes an unusual alliance with a young kitchen worker at a famous restaurant.",
                    PosterUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTMzODU0NTkxMF5BMl5BanBnXkFtZTcwMjQ4MzMzMw@@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 7,
                    Title = "City of God",
                    Year = 2002,
                    Runtime = 130,
                    Genre = Genre.Crime,
                    Director = "Fernando Meirelles, Kátia Lund",
                    Actors = "Alexandre Rodrigues, Leandro Firmino, Phellipe Haagensen, Douglas Silva",
                    Plot = "Two boys growing up in a violent neighborhood of Rio de Janeiro take different paths: one becomes a photographer, the other a drug dealer.",
                    PosterUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjA4ODQ3ODkzNV5BMl5BanBnXkFtZTYwOTc4NDI3._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 8,
                    Title = "Memento",
                    Year = 2000,
                    Runtime = 113,
                    Genre = Genre.Mystery,
                    Director = "Christopher Nolan",
                    Actors = "Guy Pearce, Carrie-Anne Moss, Joe Pantoliano, Mark Boone Junior",
                    Plot = "A man juggles searching for his wife's murderer and keeping his short-term memory loss from being an obstacle.",
                    PosterUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BNThiYjM3MzktMDg3Yy00ZWQ3LTk3YWEtN2M0YmNmNWEwYTE3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 9,
                    Title = "The Intouchables",
                    Year = 2011,
                    Runtime = 112,
                    Genre = Genre.Biography,
                    Director = "Olivier Nakache, Eric Toledano",
                    Actors = "François Cluzet, Omar Sy, Anne Le Ny, Audrey Fleurot",
                    Plot = "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver.",
                    PosterUrl = "http://ia.media-imdb.com/images/M/MV5BMTYxNDA3MDQwNl5BMl5BanBnXkFtZTcwNTU4Mzc1Nw@@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 10,
                    Title = "Stardust",
                    Year = 2007,
                    Runtime = 127,
                    Genre = Genre.Adventure,
                    Director = "Matthew Vaughn",
                    Actors = "Ian McKellen, Bimbo Hart, Alastair MacIntosh, David Kelly",
                    Plot = "In a countryside town bordering on a magical land, a young man makes a promise to his beloved that he'll retrieve a fallen star by venturing into the magical realm.",
                    PosterUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjkyMTE1OTYwNF5BMl5BanBnXkFtZTcwMDIxODYzMw@@._V1_SX300.jpg"
                }
            };

            return movies;
        }

        public IEnumerable<EnumModel> GetGenres()
        {
            return Enum
                    .GetValues(typeof(Genre))
                    .Cast<Genre>()
                    .Select(s => new EnumModel()
                    {
                        Id = (int)s,
                        Name = s.ToString()
                    }).ToList();
        }
    }
}