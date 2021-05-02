using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Api.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Runtime { get; set; }
        public string Director { get; set; }
        public string Poster { get; set; }
        public string imdbRating { get; set; }
    }
}