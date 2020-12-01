using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Configuration;
using System.Text;

namespace Movie.App.Logic
{
    public class MovieInfo
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieDescription { get; set; }
        public string ReleaseYear { get; set; }

        public static List<MovieInfo> SearchMovies (string searchTitle)
        {
            //Prepare the HttpClient variable
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["MovieKioskApiSearchMovieBaseUrl"]);
            string urlParameters = string.Concat(ConfigurationManager.AppSettings["MovieKioskApiSearchMovieUrlParams"], searchTitle);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.

            List<MovieInfo> movieList = new List<MovieInfo>();

            if (response.IsSuccessStatusCode)
            {

                var data = response.Content.ReadAsStringAsync();
                movieList = JsonConvert.DeserializeObject<List<MovieInfo>>(data.Result);
                return movieList;
                
            }

            return movieList;

        }


        public static MovieInfo GetMovie (int movieId)
        {
            //prepare httpclient variable
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["MovieKioskApiSearchMovieBaseUrl"]);
            string urlParameters = string.Concat(ConfigurationManager.AppSettings["MovieKioskApiGetMovieUrlParams"], movieId);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //data response
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.

            //List<MovieInfo> movieList = new List<MovieInfo>();
            List<MovieInfo> movie = new List<MovieInfo>();

            if (response.IsSuccessStatusCode)
            {

                var data = response.Content.ReadAsStringAsync();
                movie = JsonConvert.DeserializeObject<List<MovieInfo>>(data.Result);
                return movie.First<MovieInfo>();

            }

            return movie.First<MovieInfo>();
        }


        public static string AddMovie(MovieInfo movie)
        {

            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Post, ConfigurationManager.AppSettings["MovieKioskApiSearchMovieBaseUrl"]);

            var json = JsonConvert.SerializeObject(movie);

            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

            request.Content = stringContent;

            var response = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

             return "completed";

        }


        //public static string AddMovie(MovieInfo movie)
        //{

        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["MovieKioskApiSearchMovieBaseUrl"]);
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    var content = new StringContent(JsonConvert.SerializeObject(movie));

        //    content.Headers.ContentType.MediaType = "application/json";

        //    HttpResponseMessage response = client.PostAsync(client.BaseAddress.ToString(), content).Result;

        //    if (response.IsSuccessStatusCode)
        //    {
        //        return "Success";
        //    }
        //    return "There was an error adding this movie";

        //}


    }
}