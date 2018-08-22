using System.IO;
using System.Web;
using System.Web.Mvc;
using ReviewsWebApp.Models;
using ReviewsWebApp.Patterns;

namespace ReviewsWebApp.Controllers
{

    public class ReviewController : Controller
    {
        private readonly IReviewsFactory factory;

        public ReviewController()
        {
            string filePath = Path.Combine(HttpRuntime.AppDomainAppPath, "./reviews.json");
            IRepository<ReviewModel> reviews = new ReviewsRepository(new JsonFile(filePath));
            this.factory = new ReviewsFactory(reviews);
        }

        public ReviewController(string filePath)
        {
            IContext<JsonReviews> context = new JsonFile(filePath);
            IRepository<ReviewModel> reviews = new ReviewsRepository(context);
            this.factory = new ReviewsFactory(reviews);
        }

        public ActionResult Index(int pageNumber = 1)
        {
            ReviewsViewModel model = factory.Create(pageNumber);

            return View(model);
        }
    }
}