using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using Dapper;
using mod = MovieKiosk.API.Models;
using System.Data;
using System.Configuration;

namespace MovieKiosk.API.Data
{
    public static class Movies
    {

        public static List<Models.Movie> SearchMovies(string movieTitle)
        {

            string conString = ConfigurationManager.ConnectionStrings["DbMovieKiosk"].ConnectionString;

            var results = new List<mod.Movie>();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                var p = new DynamicParameters();
                p.Add("@titleSearch", movieTitle);

                
                results = conn.Query<mod.Movie>("usp_Movie_ByTitle_Search", p, commandType: CommandType.StoredProcedure).ToList();

                return results;

            };
        }

        public static string AddMovie(string movieTitle, string movieDescription, string releaseYear)
        {
            string conString = ConfigurationManager.ConnectionStrings["DbMovieKiosk"].ConnectionString;

            string resultMessage = "";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                var p = new DynamicParameters();
                p.Add("@movieTitle", movieTitle);
                p.Add("@movieDescription", movieDescription);
                p.Add("@releaseYear", releaseYear);


                resultMessage = conn.Query<string>("dbo.usp_Movie_WithDuplicateTitleCheck_Insert", p, commandType: CommandType.StoredProcedure).First();


                return resultMessage;

            };

        }

        public static List<mod.Movie> GetMovie(int movieId)
        {
            string conString = ConfigurationManager.ConnectionStrings["DbMovieKiosk"].ConnectionString;

            var result = new List<mod.Movie>();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                var p = new DynamicParameters();
                p.Add("@movieId", movieId);

                result = conn.Query<mod.Movie>("usp_Movie_ById_Get", p, commandType: CommandType.StoredProcedure).ToList();

                return result;


            }
        }

        public static mod.Movie EditMovie(mod.Movie movie)
        {
            string conString = ConfigurationManager.ConnectionStrings["DbMovieKiosk"].ConnectionString;

            var result = new mod.Movie();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                var p = new DynamicParameters();
                p.Add("@movieId", movie.MovieId);
                p.Add("@movieTitle", movie.MovieTitle);
                p.Add("@movieDescription", movie.MovieDescription);
                p.Add("@releaseYear", movie.ReleaseYear);


                result = (mod.Movie)conn.Query<mod.Movie>("usp_Movie_Update", p, commandType: CommandType.StoredProcedure);

                return result;


            }
        }




    }

}
        

