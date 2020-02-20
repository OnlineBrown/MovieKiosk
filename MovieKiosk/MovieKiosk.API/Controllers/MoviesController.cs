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

        // POST api/<controller>
        public string Post(string movieTitle, string movieDescription, string releaseYear)
        {
            return Data.Movies.AddMovie(movieTitle, movieDescription, releaseYear);
        }


        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}