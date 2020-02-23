using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dapper;
using Customer.Api.Models;
using System.Data;
using System.Configuration;

namespace Customer.Api.Data
{
    public class Customer
    {
        public static string AddCustomer(Models.Customer newCustomer)
        {
            string conString = ConfigurationManager.ConnectionStrings["DbMovieKiosk"].ConnectionString;
            int returnValue = -1;
            

            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();

                var p = new DynamicParameters();
                p.Add("@lastName", newCustomer.LastName);
                p.Add("@firstName", newCustomer.FirstName);
                p.Add("@emailAddress", newCustomer.EmailAddress);


                returnValue = conn.ExecuteScalar<int>("[Customer].[uspAddCustomer]", p, commandType: CommandType.StoredProcedure);

            };

            if (returnValue == 0)
            {
                return "Sucessfully added new customer.";
            }
            else
            {
                return "Error occured when adding new customer";
            }
        }
    }
}