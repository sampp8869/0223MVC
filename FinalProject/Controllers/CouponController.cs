using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;

namespace FinalProject.Controllers
{
    public class CouponController : SuperController
    {
        private readonly FinalProjectContext _context;

        public CouponController(FinalProjectContext context)
        {
            _context = context;
        }

        public IActionResult List()
        {
            List<CCouponViewModel> model = new List<CCouponViewModel>();
            var datas = from t in _context.TCoupon select t;
            foreach (var item in datas)
            {
                model.Add(new CCouponViewModel()
                {
                    FSid = item.FSid,
                    FCode = item.FCode,
                    FStartDate = item.FStartDate,
                    FEndDate = item.FEndDate,
                    FRatio = item.FRatio,
                    FAvailableTimes = item.FAvailableTimes,
                    FUsedTimes = item.FUsedTimes
                });
            }
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CCouponViewModel vm)
        {
            TCoupon c = new TCoupon();
            if ((from t in _context.TCoupon where t.FCode == vm.FCode select t) == null)
            {
                c.FCode = vm.FCode;
                c.FStartDate = vm.FStartDate;
                c.FEndDate = vm.FEndDate;
                c.FRatio = vm.FRatio;
                c.FAvailableTimes = vm.FAvailableTimes;
                c.FUsedTimes = vm.FUsedTimes;
                _context.TCoupon.Add(c);
                _context.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                TCoupon delCoupon = _context.TCoupon.FirstOrDefault(t => t.FSid == id);
                if (delCoupon != null)
                {
                    _context.TCoupon.Remove(delCoupon);
                    _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("List");
        }

        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                TCoupon c = _context.TCoupon.FirstOrDefault(t => t.FSid == id);
                if (c != null)
                {
                    CCouponViewModel vm = new CCouponViewModel();
                    vm.FSid = c.FSid;
                    vm.FCode = c.FCode;
                    vm.FStartDate = c.FStartDate;
                    vm.FEndDate = c.FEndDate;
                    vm.FRatio = c.FRatio;
                    vm.FAvailableTimes = c.FAvailableTimes;
                    vm.FUsedTimes = c.FUsedTimes;
                    return View(vm);
                }
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Edit(CCouponViewModel vm)
        {
            TCoupon c = _context.TCoupon.FirstOrDefault(t => t.FSid == vm.FSid);
            if (c != null)
            {
                c.FStartDate = vm.FStartDate;
                c.FEndDate = vm.FEndDate;
                c.FRatio = vm.FRatio;
                c.FAvailableTimes = vm.FAvailableTimes;
                c.FUsedTimes = vm.FUsedTimes;
                _context.SaveChangesAsync();
            }
            return RedirectToAction("List");
        }
    }
}
