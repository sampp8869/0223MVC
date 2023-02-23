using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class ProviderReviewController : SuperController
    {
		private readonly FinalProjectContext _context;
		public ProviderReviewController(FinalProjectContext context)
		{
			_context = context;
		}
		public IActionResult List()
        {
            IEnumerable<TProductReview> datas = null;
            datas = from t in _context.TProductReview select t;
            return View(datas);
        }
    }
}
