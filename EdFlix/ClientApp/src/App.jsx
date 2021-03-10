import React, { useState, useEffect } from "react";
//import Layout from "./components/Layout";
import { Movies } from "./components/Movies";
import { Sidebar } from "./components/Sidebar";

import "./custom.css";

const BASE_URL = "http://localhost:5000";

const App = () => {
  const [movies, setMovies] = useState([]);
  const [genres, setGenres] = useState([]);
  const [selectedGenre, setSelectedGenre] = useState(null);

  const getMovies = async () => {
    const res = await fetch(`${BASE_URL}/movies`);
    const jsonRes = await res.json();

    setMovies(jsonRes);
  }

  const getGenres = async () => {
    const res = await fetch(`${BASE_URL}/movies/genres`);
    const jsonRes = await res.json();

    setGenres(jsonRes);
  }

  const handleClick = (value) => {
    setSelectedGenre(value);
  }


  useEffect(() => {
    getMovies();
    getGenres();
  }, [])

  return (
    <div>
      <h1>Movie App</h1>
      <Sidebar 
        genres={genres} 
        handleClick={handleClick} 
      />
      <Movies 
        movies={movies} 
        selectedGenre={selectedGenre} 
      />
    </div>
  )
};

export default App;
