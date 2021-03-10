# challenge-EdFlix

**Movie Backend**
* GET /movies - receive movies data
* GET /movies/genres - recieve all genres, transformed enum to a list of id and value. Frontend will use this id to show categorized movies
* Used a Repostiory Pattern to create loosely coupled codes
  * /Abstraction: Interfaces
  * /Repository: Encapsulates a set of objects stored in the database. In this case, we do not have database
  * /Model: Models and Enum
  * /Controller: API Endpoint and use methods from repositories

**Movie Frontend**
* Receive genres from Backend
* Receive movies from Backend
* Implemented a category selection feature
* CSS designs were not implemetned at the moment

**ShapeBucket OOP Design**
* OOP challenge is located in the root/OOP.cs
* Focused on adding different colored shape to ShapeBucket, and throw an error if it is not a correct bucket
