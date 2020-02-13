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

        public static List<Models.Movie> SearchMovies(string searchTerm)
        {

            string conString = ConfigurationManager.ConnectionStrings["DbMovieKiosk"].ConnectionString;

            var results = new List<mod.Movie>();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                var p = new DynamicParameters();
                p.Add("@titleSearch", searchTerm);

                //results = conn.Execute("usp_Movie_ByTitle_Search", p, commandType: CommandType.StoredProcedure);
                results = conn.Query<mod.Movie>("usp_Movie_ByTitle_Search", p, commandType: CommandType.StoredProcedure).ToList();

                return results;

            };




        }

    }

}
        

