using System.Web.Mvc;

namespace ReviewsWebApp.Controllers
{
    public class ReviewController : Controller
    {
        // GET: Review
        public ActionResult Index()
        {
            return View();
        }
    }
}