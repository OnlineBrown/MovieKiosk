using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using Dapper;




namespace MovieKiosk.API.Data
{
    public class GetMovies
    {

        public List<Models.Movie> movies = new List<Models.Movie>();

        SqlConnection sqlconn = new SqlConnection();

    }



}