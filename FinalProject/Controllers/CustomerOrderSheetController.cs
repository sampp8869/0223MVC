using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class CustomerOrderSheetController : Controller
    {
        private readonly FinalProjectContext _context;
        public CustomerOrderSheetController(FinalProjectContext context)
        {
            _context = context;
        }

        public IActionResult ListUnchecked()
        {
            IEnumerable<TCustomerOrderSheet> datas = null;
            datas = from t in _context.TCustomerOrderSheet
                    where t.FCheckedDate == null
                    select t;
            return View(datas);
        }

        public IActionResult ListChecked()
        {
            IEnumerable<TCustomerOrderSheet> datas = null;
            datas = from t in _context.TCustomerOrderSheet
                    where t.FCheckedDate != null
                    select t;
            return View(datas);
        }

        public IActionResult Confirm(int? id)
        {
            if (id != null)
            {
                TCustomerOrderSheet x = _context.TCustomerOrderSheet.FirstOrDefault(t => t.FId == id);
                if (x != null)
                    x.FCheckedDate = DateTime.Now;
                    _context.SaveChangesAsync();                
            }
            return RedirectToAction("ListUnchecked");
        }
    }
}
