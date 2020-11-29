using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieKiosk.API.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieDescription { get; set; }
        public string ReleaseYear { get; set; }
    }
}