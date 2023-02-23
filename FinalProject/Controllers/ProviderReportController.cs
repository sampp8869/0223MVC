using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class ProviderReportController : SuperController
    {
		private readonly FinalProjectContext _context;
		public ProviderReportController(FinalProjectContext context)
		{
			_context = context;
		}
		public IActionResult List()
        {
            IEnumerable<TProductReport> datas = null;
            datas = from t in _context.TProductReport select t;
            return View(datas);
        }
    }
}
