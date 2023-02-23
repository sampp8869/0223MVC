using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class CustomerOrderSheetController : Controller
    {
               
        public IActionResult List_uncheck()
        {
            IEnumerable<TCustomerOrderSheet> datas = null;
            FinalProjectContext db = new FinalProjectContext();
            datas = from t in db.TCustomerOrderSheets
                    where t.FCheckedDate==null
                    select t;
            return View(datas);
        }

        public IActionResult List_checked()
        {
            IEnumerable<TCustomerOrderSheet> datas = null;
            FinalProjectContext db = new FinalProjectContext();
            datas = from t in db.TCustomerOrderSheets
                    where t.FCheckedDate != null
                    select t;
            return View(datas);
        }

        public IActionResult Confirm(int? id)
        {
            if (id != null)
            {
                FinalProjectContext db = new FinalProjectContext();
                TCustomerOrderSheet x = db.TCustomerOrderSheets.FirstOrDefault(t => t.FId == id);
                if (x != null)
                    x.FCheckedDate = DateTime.Now;
                    db.SaveChangesAsync();                
            }
            return RedirectToAction("List_uncheck");
        }
    }
}
