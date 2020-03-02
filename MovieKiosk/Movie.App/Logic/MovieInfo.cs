using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Configuration;

namespace Movie.App.Logic
{
    public class MovieInfo
    {
        public string MovieTitle { get; set; }
        public string Description { get; set; }
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


    }
}