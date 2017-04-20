using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryRevised.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public string Genre { get; set; }
        public bool IsCheckedOut { get; set; } = false;
        public DateTime? LastCheckedOutDate { get; set; } = DateTime.Now;
        public DateTime? DueBackDate { get; set; } = DateTime.Now.AddDays(10);
        public string ResponseMessage { get; set; } 
    }
}