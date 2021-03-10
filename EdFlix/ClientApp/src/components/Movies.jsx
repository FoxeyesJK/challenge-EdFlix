import * as React from "react";

export const Movies = ({ movies, selectedGenre }) => (
  <div className="movies-container">
    <h2>Movies</h2>
    {
      movies && movies
        .filter(movie => selectedGenre !== null ? movie.genre === selectedGenre : movie)
        .map(movie => 
        <div key={movie.id}>
          {movie.title}
        </div>
        )
    }

  </div>
);