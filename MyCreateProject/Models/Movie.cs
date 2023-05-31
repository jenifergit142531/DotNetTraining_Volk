using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyCreateProject.Models
{
    public class Movie
    {
        
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int TicketPrice { get; set; }

    }
}