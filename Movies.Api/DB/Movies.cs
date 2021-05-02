using Movies.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Api.DB
{
    public class Movies
    {
        private static List<Movie> _movies;

        public Movies()
        {
            _movies = new List<Movie>();
            if (_movies.Count == 0)
            {
                _movies = new List<Movie>() {
                    new Movie() {
                        MovieId=1,
                        Title="Batman",
                        Director="Tim Burton",
                        imdbRating="7.5",
                        Poster="https://m.media-amazon.com/images/M/MV5BMTYwNjAyODIyMF5BMl5BanBnXkFtZTYwNDMwMDk2._V1_SX300.jpg",
                        Runtime="126 min",
                        Year=1989
                    },
                    new Movie() {
                        MovieId=2,
                        Title="Catwoman",
                        Director="Pitof",
                        imdbRating="3.4",
                        Poster="https://m.media-amazon.com/images/M/MV5BMjA4MzM0NDAzOF5BMl5BanBnXkFtZTcwMDY3MDYyMQ@@._V1_SX300.jpg",
                        Runtime="104 min",
                        Year=2004
                    },
                    new Movie() {
                        MovieId=3,
                        Year=1964,
                        imdbRating="5.6",
                        Title="Darasingh: Ironman",
                        Director="Kedar Kapoor",
                        Poster="https://m.media-amazon.com/images/M/MV5BZTVkMmE1OWYtMDdhZC00Mjg2LWEzNzktMWZiMjAxMmU0YTM0XkEyXkFqcGdeQXVyODQwMDcwNDY@._V1_SX300.jpg",
                        Runtime="N/A"
                    },
                    new Movie() {
                        MovieId=4,
                        Title="Superman",
                        Year=1978,
                        Runtime="143 min",
                        imdbRating="7.3",
                        Director="Richard Donner",
                        Poster="https://m.media-amazon.com/images/M/MV5BMzA0YWMwMTUtMTVhNC00NjRkLWE2ZTgtOWEzNjJhYzNiMTlkXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SX300.jpg"
                    },
                    new Movie() {
                        MovieId=5,
                        Title="Fantastika vs. Wonderwoman",
                        Year=1976,
                        Runtime="N/A",
                        imdbRating="N/A",
                        Director="Johnny Pangilinan",
                        Poster="N/A"
                    },
                    new Movie() {
                        MovieId=6,
                        Title="Captain America",
                        Year=2011,
                        Runtime="124 min",
                        imdbRating="6.9",
                        Director="Joe Johnston",
                        Poster="https://m.media-amazon.com/images/M/MV5BMTYzOTc2NzU3N15BMl5BanBnXkFtZTcwNjY3MDE3NQ@@._V1_SX300.jpg"
                    }
                };
            }
        }

        public List<Movie> GetAll()
        {
            return _movies;
        }

        public Movie Details(int id)
        {
            return _movies.Find(x => x.MovieId == id);
        }

        public List<Movie> FindByName(string name)
        {
            return _movies.Where(x => x.Title.Contains(name)).ToList();
        }
    }
}