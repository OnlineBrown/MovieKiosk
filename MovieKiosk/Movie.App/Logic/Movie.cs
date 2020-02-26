using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Movie.App.Logic
{
    public class Movie
    {
        public string MovieTitle { get; set; }
        public string Description { get; set; }
        public string ReleaseYear { get; set; }

        public static void SearchMovies (string searchTitle)
        {

            //public static List<Movie> SearchMovies (string searchTitle)

            HttpClient client = new HttpClient();
            //https://localhost:44331/api/Movies?movieTitle={movieTitle}
            client.BaseAddress = new Uri("https://localhost:44331/api/Movies");

            string urlParameters = string.Concat("?movieTitle=", searchTitle);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            


            if (response.IsSuccessStatusCode)
            {

                var data = response.Content.ReadAsStringAsync();
                List<Movie> movieList = JsonConvert.DeserializeObject<List<Movie>>(data.Result);
                // Parse the response body.
                //var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                //var dataObjects = response.Content.ReadAsStringAsync().Result.ToList();
                //var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Logic.Movie>(dataObjects.Result.ToString());
                //    foreach (var d in dataObjects)
                //    {
                //        Console.WriteLine("{0}", d.Name);
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

        }


    }
}