using System.Collections.Generic;
using ReviewsWebApp.Models;

namespace ReviewsWebApp.Patterns
{
    public class ReviewsFactory : IReviewsFactory
    {
        private readonly IRepository<ReviewModel> reviews;

        const int ReviewsPerPage = 3;
        const int TopRatingScore = 6;
         

        public ReviewsFactory(IRepository<ReviewModel> reviews)
        {
            this.reviews = reviews;
        }

        public ReviewsViewModel Create(int pageNumber)
        {
            int pageCount = (reviews.Count() / ReviewsPerPage) + 1;

            if (pageNumber < 1 || pageNumber > pageCount)
                return new ReviewsViewModel();

            bool isNextPageEnabled = pageNumber < pageCount;
            bool isPreviousPageEnabled = pageNumber > 1;
            var startIndex = (pageNumber - 1) * ReviewsPerPage;

            var list = reviews.GetSubListReviews(startIndex, ReviewsPerPage);

            var model = new ReviewsViewModel
            {
                ReviewsPerPage = ReviewsPerPage,
                TopRatingScore = TopRatingScore,
                PageNumber = pageNumber,
                PageCount = pageCount,
                IsNextPageEnabled = isNextPageEnabled,
                IsPreviousPageEnabled = isPreviousPageEnabled,
                Reviews = list
            };

            return model;
        }

    }
}