using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View(Logic.MovieInfo.SearchMovies(txtMovieTitleSearch));
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