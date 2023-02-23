using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using FinalProject.ViewModels;
using System.Diagnostics;
using System.Text.Json;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOINGED_ADMIN))
                return RedirectToAction("Login");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(CLoginViewModel vm)
        {
            TManager admin = (new FinalProjectContext()).TManagers.FirstOrDefault(
         t => t.FAccount.Equals(vm.txtAccount) && t.FPassword.Equals(vm.txtPassword));

            if (admin != null && admin.FPassword.Equals(vm.txtPassword))
            {
                string json = JsonSerializer.Serialize(admin);
                HttpContext.Session.SetString(CDictionary.SK_LOINGED_ADMIN, json);
                return RedirectToAction("Index");

            }
            return View();
        }
    }
}