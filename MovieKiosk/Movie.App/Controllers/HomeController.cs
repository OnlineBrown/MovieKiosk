using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie.App.Logic;

namespace Movie.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MovieSearch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MovieSearch(string txtMovieTitleSearch)
        {
            //Logic.Movie.SearchMovies(txtMovieTitleSearch);
            //return View(Logic.MovieInfo.SearchMovies(txtMovieTitleSearch));
            return View("MovieSearchResults", Logic.MovieInfo.SearchMovies(txtMovieTitleSearch));
        }
        
        public ActionResult MovieAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MovieAdd(MovieInfo movie)
        {
            Logic.MovieInfo.AddMovie(movie);
            return View("MovieSearchResults", Logic.MovieInfo.SearchMovies(movie.MovieTitle.ToString()));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}