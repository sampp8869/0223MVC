using Microsoft.AspNetCore.Mvc;
using ReviewRerport.Models;

namespace ReviewRerport.Controllers
{
    public class ProviderReviewController : Controller
    {
        public IActionResult List()
        {
            IEnumerable<TProductReview> datas = null;
            FinalProjectContext finalProject = new FinalProjectContext();
            datas = from t in finalProject.TProductReviews select t;
            return View(datas);
        }
    }
}
