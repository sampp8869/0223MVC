using Microsoft.AspNetCore.Mvc;
using ReviewRerport.Models;
using ReviewRerport.ViewModels;
using System.ComponentModel;

namespace ReviewRerport.Controllers
{
    public class ManagerReviewController : Controller
    {
        public IActionResult List()
        {
            FinalProjectContext finalProject = new FinalProjectContext();
            List<CManagerReviewListViewModel> model = new List<CManagerReviewListViewModel>();
            var datas = (from productReview in finalProject.TProductReviews
                         join orderDetail in finalProject.TOrderDetails on productReview.FOrderDetailId equals orderDetail.FId
                         join product in finalProject.TProducts on orderDetail.FProductId equals product.FId
                         join provider in finalProject.TProviders on product.FProviderId equals provider.FId
                         where !product.FRemoved
                         select new
                         {
                             ReviewID = productReview.FId,
                             ProductName = product.FName,
                             ProductProvider = provider.FCompanyName,
                             ReviewContent = productReview.FReviewContent,
                             ReviewScore = productReview.FScore,
                             CreateDateTime = productReview.FCreationDate
                         }).ToList();
            foreach (var item in datas)
            {
                model.Add(new CManagerReviewListViewModel()
                {
                    ReviewID = item.ReviewID,
                    ProductName = item.ProductName,
                    ProductProvider = item.ProductProvider,
                    ReviewContent = item.ReviewContent,
                    ReviewScore = item.ReviewScore,
                    CreateDateTime = item.CreateDateTime
                });
            }
            return View(model);
        }


        public IActionResult Details(int? id)
        {

            FinalProjectContext finalProject = new FinalProjectContext();
            List<CManagerReviewDetailViewModel> model = new List<CManagerReviewDetailViewModel>();
            if (id != null)
            {
                var datas = (from productReview in finalProject.TProductReviews
                             join orderDetail in finalProject.TOrderDetails on productReview.FOrderDetailId equals orderDetail.FId
                             join customerSheet in finalProject.TCustomerOrderSheets on orderDetail.FCustomerOrderSheetId equals customerSheet.FId
                             join customer in finalProject.TCustomers on customerSheet.FCustomerId equals customer.FId
                             join product in finalProject.TProducts on orderDetail.FProductId equals product.FId
                             join provider in finalProject.TProviders on product.FProviderId equals provider.FId
                             where productReview.FId == id
                             select new
                             {
                                 ReviewID = productReview.FId,
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
                                 ReviewScore = productReview.FScore,
                                 ReviewContent = productReview.FReviewContent,
                                 CreateDateTime = productReview.FCreationDate
                             }).ToList();
                foreach (var item in datas)
                {
                    model.Add(new CManagerReviewDetailViewModel()
                    {
                        ReviewID = item.ReviewID,
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
                        ReviewScore = item.ReviewScore,
                        ReviewContent = item.ReviewContent,
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
