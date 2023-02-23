using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class PurchaseOrderSheetController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
