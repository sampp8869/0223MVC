using Microsoft.AspNetCore.Mvc;
using ReviewRerport.Models;
using ReviewRerport.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using Microsoft.CodeAnalysis;

namespace ReviewRerport.Controllers
{
    public class ManagerReportController : Controller
    {

        public IActionResult List()
        {
            FinalProjectContext finalProject = new FinalProjectContext();
            List<CManagerReportListViewModel> model = new List<CManagerReportListViewModel>();
            var datas = (from productReport in finalProject.TProductReports
                         join orderDetail in finalProject.TOrderDetails on productReport.FOrderDetailId equals orderDetail.FId
                         join customerSheet in finalProject.TCustomerOrderSheets on orderDetail.FCustomerOrderSheetId equals customerSheet.FId
                         join customer in finalProject.TCustomers on customerSheet.FCustomerId equals customer.FId
                         join product in finalProject.TProducts on orderDetail.FProductId equals product.FId
                         join provider in finalProject.TProviders on product.FProviderId equals provider.FId
                         where !product.FRemoved
                         select new
                         {
                             ReportID = productReport.FId,
                             ProductName = product.FName,
                             ProductProvider = provider.FCompanyName,
                             ReportContent = productReport.FReportContent,
                             CreateDateTime = productReport.FCreationDate
                         }).ToList();
            foreach (var item in datas)
            {
                model.Add(new CManagerReportListViewModel()
                {
                    ReportID = item.ReportID,
                    ProductName = item.ProductName,
                    ProductProvider = item.ProductProvider,
                    ReportContent = item.ReportContent,
                    CreateDateTime = item.CreateDateTime
                });
            }
            return View(model);
        }

        public IActionResult Details(int? id)
        {

            FinalProjectContext finalProject = new FinalProjectContext();
            List<CManagerReportDetailViewModel> model = new List<CManagerReportDetailViewModel>();
            if (id != null)
            {
                var datas = (from productReport in finalProject.TProductReports
                             join orderDetail in finalProject.TOrderDetails on productReport.FOrderDetailId equals orderDetail.FId
                             join customerSheet in finalProject.TCustomerOrderSheets on orderDetail.FCustomerOrderSheetId equals customerSheet.FId
                             join customer in finalProject.TCustomers on customerSheet.FCustomerId equals customer.FId
                             join product in finalProject.TProducts on orderDetail.FProductId equals product.FId
                             join provider in finalProject.TProviders on product.FProviderId equals provider.FId
                             where productReport.FId == id
                select new
                             {
                                 ReportID = productReport.FId,
                                 ProductProviderID = provider.FId,
                                 ProductProvider = provider.FCompanyName,
                                 ProductProviderTel = provider.FContactTel,
                                 ProductProviderMobile = provider.FContactMobile,
                                 ProductProviderEmail = provider.FContactEmail,
                                 ProductID = product.FId,
                                 ProductName = product.FName,
                                 ProductDescription = product.FDescription,
                                 ProductPoint = product.FAssemblyPoint,
                                 ProductRemark = product.FRemark,
                                 CustomerID = customer.FId,
                                 CustomerLastName = customer.FLastName,
                                 CustomerFirstName = customer.FFirstName,
                                 CustomerTel = customer.FTel,
                                 CustomerMobile = customer.FMobile,
                                 CustomerEmail = customer.FEmail,
                                 ReportContent = productReport.FReportContent,
                                 CreateDateTime = productReport.FCreationDate
                             }).ToList();
                foreach (var item in datas)
                {
                    model.Add(new CManagerReportDetailViewModel()
                    {
                        ReportID = item.ReportID,
                        ProductProviderID = item.ProductProviderID,
                        ProductProvider = item.ProductProvider,
                        ProductProviderTel = item.ProductProviderTel,
                        ProductProviderMobile = item.ProductProviderMobile,
                        ProductProviderEmail = item.ProductProviderEmail,
                        ProductID = item.ProductID,
                        ProductName = item.ProductName,
                        ProductDescription = item.ProductDescription,
                        ProductPoint = item.ProductPoint,
                        ProductRemark = item.ProductRemark,
                        CustomerID = item.CustomerID,
                        CustomerLastName = item.CustomerLastName,
                        CustomerFirstName = item.CustomerFirstName,
                        CustomerTel = item.CustomerTel,
                        CustomerMobile = item.CustomerMobile,
                        CustomerEmail = item.CustomerEmail,
                        ReportContent = item.ReportContent,
                        CreateDateTime = item.CreateDateTime
                    });
                }
                return View(model[0]);
            }
            return RedirectToAction("List");
        }
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                FinalProjectContext finalProject = new FinalProjectContext();
                TProductReview delReview = finalProject.TProductReviews.FirstOrDefault(t => t.FId == id);
                if (delReview != null)
                {
                    finalProject.TProductReviews.Remove(delReview);
                    finalProject.SaveChangesAsync();
                }
            }
            return RedirectToAction("List");
        }

    }

}
