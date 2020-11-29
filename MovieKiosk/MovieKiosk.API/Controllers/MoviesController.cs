using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mod = MovieKiosk.API.Models;


namespace MovieKiosk.API.Controllers
{
    public class MoviesController : ApiController
    {

        //Get api/<controller>
        public List<mod.Movie> Get(string movieTitle)
        {
            return Data.Movies.SearchMovies(movieTitle);
        }

        public List<mod.Movie> Get(int movieId)
        {
            return Data.Movies.GetMovie(movieId);
        }

        // POST api/<controller>
        public string Post(mod.Movie movie)
        {
            return Data.Movies.AddMovie(movie.MovieTitle, movie.MovieDescription, movie.ReleaseYear);
        }

        //Put api/<controller>
        //public mod.Customer Put(int movieId)
        //{
        //    return Data.Movies.
        //}


    }
}