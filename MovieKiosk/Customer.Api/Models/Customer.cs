using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer.Api.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}