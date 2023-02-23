using Microsoft.AspNetCore.Mvc;
using ReviewRerport.Models;

namespace ReviewRerport.Controllers
{
    public class ProviderReportController : Controller
    {
        public IActionResult List()
        {
            IEnumerable<TProductReport> datas = null;
            FinalProjectContext finalProject = new FinalProjectContext();
            datas = from t in finalProject.TProductReports select t;
            return View(datas);
        }
    }
}
