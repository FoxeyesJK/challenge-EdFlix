using System;
using System.Collections.Generic;

namespace EdFlix.Models 
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }
        
        public int Runtime { get; set; }
        
        public Genre Genre { get; set; }

        public string Director { get; set; }

        public string Actors { get; set; }

        public string Plot { get; set; }

        public string PosterUrl { get; set; }
    }

    public class EnumModel
    {
        public int Id { get; set; }
        public string Name { get; set;}
    }

    public enum Genre
    {
        Comedy,
        Fantasy,
        Crime,
        Drama,
        Music,
        Adventure,
        History,
        Thriller,
        Animation,
        Family,
        Mystery,
        Biography,
        Action,
        FilmNoir,
        Romance,
        SciFi,
        War,
        Western,
        Horror,
        Musical,
        Sport
    }
}