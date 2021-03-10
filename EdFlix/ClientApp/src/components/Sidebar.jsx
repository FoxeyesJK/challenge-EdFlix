import * as React from "react";

export const Sidebar = ({ 
  genres, 
  handleClick,
}) => (
  <div>
    <h3>Filter by genres</h3>
    <div className="genres-container">
    {
      genres.map(genre => 
        <div
          key={genre.id} 
          className="genres-item"
          onClick={() => handleClick(genre.id)}
        >
          {genre.name}
        </div>
        )
    }
    </div>
  </div>
);
