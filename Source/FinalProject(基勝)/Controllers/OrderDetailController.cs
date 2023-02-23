using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using FinalProject.ViewModels;
using System.ComponentModel;

namespace FinalProject.Controllers
{
    public class OrderDetailController : Controller
    {
        public IActionResult List_uncheck()
        {
            FinalProjectContext db = new FinalProjectContext();
            List<COrderDetailListViewModel> model = new List<COrderDetailListViewModel>();
            var datas = (from OrderDetail in db.TOrderDetails
                         join Product in db.TProducts on OrderDetail.FProductId equals Product.FId
                         join CustomerOrderSheet in db.TCustomerOrderSheets on OrderDetail.FCustomerOrderSheetId equals CustomerOrderSheet.FId
                         join Customer in db.TCustomers on CustomerOrderSheet.FCustomerId equals Customer.FId
                         where CustomerOrderSheet.FCheckedDate == null
                         select new
                         {
                             OrderID= OrderDetail.FId,
                             CustomerLastName= Customer.FLastName,
                             CustomerFirstName= Customer.FFirstName,
                             ProductName = Product.FName,
                             OrderCheckedDate = CustomerOrderSheet.FCheckedDate

                         }).ToList();
            foreach(var data in datas )
            {
                model.Add(new COrderDetailListViewModel()
                {
                    OrderID= data.OrderID,
                    CustomerLastName = data.CustomerLastName,
                    CustomerFirstName = data.CustomerFirstName,
                    ProductName = data.ProductName,
                    OrderCheckedDate = data.OrderCheckedDate
                });
            }
                
            
            return View(model);
        }

        public IActionResult List_checked()
        {
            FinalProjectContext db = new FinalProjectContext();
            List<COrderDetailListViewModel> model = new List<COrderDetailListViewModel>();
            var datas = (from OrderDetail in db.TOrderDetails
                         join Product in db.TProducts on OrderDetail.FProductId equals Product.FId
                         join CustomerOrderSheet in db.TCustomerOrderSheets on OrderDetail.FCustomerOrderSheetId equals CustomerOrderSheet.FId
                         join Customer in db.TCustomers on CustomerOrderSheet.FCustomerId equals Customer.FId
                         where CustomerOrderSheet.FCheckedDate != null
                         select new
                         {
                             OrderID = OrderDetail.FId,
                             CustomerLastName = Customer.FLastName,
                             CustomerFirstName = Customer.FFirstName,
                             ProductName = Product.FName,
                             OrderCheckedDate = CustomerOrderSheet.FCheckedDate

                         }).ToList();
            foreach (var data in datas)
            {
                model.Add(new COrderDetailListViewModel()
                {
                    OrderID = data.OrderID,
                    CustomerLastName = data.CustomerLastName,
                    CustomerFirstName = data.CustomerFirstName,
                    ProductName = data.ProductName,
                    OrderCheckedDate = data.OrderCheckedDate
                });
            }


            return View(model);
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
