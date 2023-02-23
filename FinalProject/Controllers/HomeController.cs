using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly FinalProjectContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, FinalProjectContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOINGED_ADMIN))  //帳號沒有在session裡面 防偷連
            {
                return RedirectToAction("Login");
            }               
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
            if(CGlobalParameters.Login)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(CLoginViewModel vm)
        {
            TManager admin = _context.TManager.FirstOrDefault(
         t => t.FAccount.Equals(vm.txtAccount) && t.FPassword.Equals(vm.txtPassword));

            if (admin != null && admin.FPassword.Equals(vm.txtPassword))   //確保帳號密碼大小寫相符 所以再比對密碼
            {
                string json = JsonSerializer.Serialize(admin);   //物件變字串 admin Serialize成字串
                HttpContext.Session.SetString(CDictionary.SK_LOINGED_ADMIN, json);   //後面字串裡面要放json字串
                CGlobalParameters.Login = true;
                CGlobalParameters.LoginName = "管理員: " + admin.FAccount;
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(CDictionary.SK_LOINGED_ADMIN);
            CGlobalParameters.Login = false;
            CGlobalParameters.LoginName = "未登入";
            return RedirectToAction("Login");
        }
    }
}