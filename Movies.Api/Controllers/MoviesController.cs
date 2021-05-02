using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Api.Models;

namespace Movies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public ActionResult<List<Movie>> GetAll()
        {
            var movies = new DB.Movies().GetAll();
            if (movies == null)
            {
                return NotFound();
            }
            return Ok(movies);
        }

        public ActionResult<Movie> Details(int id)
        {
            var movie = new DB.Movies().Details(id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }
    }
}