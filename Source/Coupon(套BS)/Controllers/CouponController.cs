using Coupon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coupon.Controllers
{
    public class CouponController : Controller
    {
        public IActionResult List()
        {
            IEnumerable<TCoupon> datas = null;
            FinalProjectContext finalProject = new FinalProjectContext();
            datas = from t in finalProject.TCoupons select t;
            return View(datas);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TCoupon p)
        {
            FinalProjectContext finalProject = new FinalProjectContext();
            finalProject.TCoupons.Add(p);
            finalProject.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                FinalProjectContext finalProject = new FinalProjectContext();
                TCoupon delCoupon = finalProject.TCoupons.FirstOrDefault(t => t.FSid == id);
                if (delCoupon != null)
                {
                    finalProject.TCoupons.Remove(delCoupon);
                    finalProject.SaveChangesAsync();
                }
            }
            return RedirectToAction("List");
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                FinalProjectContext finalProject = new FinalProjectContext();
                TCoupon x = finalProject.TCoupons.FirstOrDefault(t => t.FSid == id);
                if (x != null)
                    return View(x);

            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public ActionResult Edit(TCoupon p)
        {
            FinalProjectContext finalProject = new FinalProjectContext();
            TCoupon x = finalProject.TCoupons.FirstOrDefault(t => t.FSid == p.FSid);
            if (x != null)
            {
                x.FCode = p.FCode;
                x.FStartDate = p.FStartDate;
                x.FEndDate = p.FEndDate;
                x.FRatio = p.FRatio;
                x.FAvailableTimes
                    = p.FAvailableTimes;
                x.FUsedTimes = p.FUsedTimes;
                finalProject.SaveChangesAsync();
            }
            return RedirectToAction("List");
        }
    

    }
}
