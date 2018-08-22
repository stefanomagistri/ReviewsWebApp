using ReviewsWebApp.Models;

namespace ReviewsWebApp.Patterns
{
    public interface IReviewsFactory
    {
        ReviewsViewModel Create(int pageNumber);
    }
}