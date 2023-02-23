using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class CouponController : Controller
    {
        public IActionResult List()
        {
            IEnumerable<TCoupon> datas = null;
            FinalProjectContext db = new FinalProjectContext();
            datas = from t in db.TCoupons
                    select t;
            return View(datas);
        }
    }
}
