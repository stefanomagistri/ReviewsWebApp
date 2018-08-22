using System;

namespace ReviewsWebApp.Models
{
    public class ReviewModel
    {
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string ShipName { get; set; }
        public string CruiseLine { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
    }
}