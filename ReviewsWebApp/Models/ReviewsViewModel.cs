using System.Collections.Generic;

namespace ReviewsWebApp.Models
{
    public class ReviewsViewModel
    {
        public ReviewsViewModel()
        {
            Reviews = new List<ReviewModel>();
        }

        public int ReviewsPerPage { get; set; }
        public int TopRatingScore { get; set; }
        public int PageCount { get; set; }
        public int PageNumber { get; set; }
        public IEnumerable<ReviewModel> Reviews { get; set; }
        public bool IsNextPageEnabled { get; set; }
        public bool IsPreviousPageEnabled { get; set; }
    }
}