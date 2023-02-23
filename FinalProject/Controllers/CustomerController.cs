using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class CustomerController : SuperController
    {
        private readonly FinalProjectContext _context;
        public CustomerController(FinalProjectContext context)
        {
            _context = context;
        }

        public IActionResult List()
        {
            List<CCustomerViewModel> model = new List<CCustomerViewModel>();
            var datas = (from customer in _context.TCustomer
                         join gender in _context.TGender on customer.FGender equals gender.FId
                         select new
                         {
                             FCustomerId = customer.FId,
                             FLastName = customer.FLastName,
                             FFirstName = customer.FFirstName,
                             FGender = gender.FDescription,
                             FTel = customer.FTel,
                             FMobile = customer.FMobile,
                             FEmail = customer.FEmail,
                             FPassword = customer.FPassword,
                             FBirthDate = customer.FBirthDate

                         }).ToList();
            foreach (var item in datas)
            {
                model.Add(new CCustomerViewModel()
                {
                    FCustomerId = item.FCustomerId,
                    FLastName = item.FLastName,
                    FFirstName = item.FFirstName,
                    FGender = item.FGender,
                    FTel = item.FTel,
                    FMobile = item.FMobile,
                    FEmail = item.FEmail,
                    FPassword = item.FPassword,
                    FBirthDate = item.FBirthDate
                });
            }
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TCustomer p)
        {
            p.FCreationDate = DateTime.Now;
            p.FLastUpdateDate = DateTime.Now;
            _context.TCustomer.Add(p);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                TCustomer delCustomer = _context.TCustomer.FirstOrDefault(t => t.FId == id);
                if (delCustomer != null)
                {
                    _context.TCustomer.Remove(delCustomer);
                    _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("List");
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                TCustomer x = _context.TCustomer.FirstOrDefault(t => t.FId == id);
                if (x != null)
                {
                    CCustomerViewModel p = new CCustomerViewModel();
                    p.FCustomerId = x.FId;
                    p.FLastName = x.FLastName;
                    p.FFirstName = x.FFirstName;
                    p.FGenderId = x.FGender;
                    p.FTel = x.FTel;
                    p.FMobile = x.FMobile;
                    p.FEmail = x.FEmail;
                    p.FPassword = x.FPassword;
                    p.FBirthDate = x.FBirthDate;
                    p.FPoint = x.FPoint;
                    p.FRemark = x.FRemark;
                    p.FBlackList = x.FBlackList;
                    p.FCreationDate = x.FCreationDate;
                    p.FLastUpdateDate = x.FLastUpdateDate;

                    return View(p);
                }
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public ActionResult Edit(CCustomerViewModel p)
        {
            TCustomer x = _context.TCustomer.FirstOrDefault(t => t.FId == p.FCustomerId);
            if (x != null)
            {
                x.FFirstName = p.FFirstName;
                x.FLastName = p.FLastName;
                x.FTel = p.FTel;
                x.FMobile = p.FMobile;
                x.FEmail = p.FEmail;
                x.FPassword = p.FPassword;
                x.FBirthDate = p.FBirthDate;
                x.FPoint = p.FPoint;
                x.FRemark = p.FRemark;
                x.FBlackList = p.FBlackList;
                x.FLastUpdateDate = DateTime.Now;
                _context.SaveChangesAsync();
            }
            return RedirectToAction("List");
        }
        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                List<CCustomerViewModel> model = new List<CCustomerViewModel>();
                var datas = (from customer in _context.TCustomer
                             join gender in _context.TGender on customer.FGender equals gender.FId
                             where customer.FId == id
                             select new
                             {
                                 FCustomerId = customer.FId,
                                 FLastName = customer.FLastName,
                                 FFirstName = customer.FFirstName,
                                 FGender = gender.FDescription,
                                 FTel = customer.FTel,
                                 FMobile = customer.FMobile,
                                 FEmail = customer.FEmail,
                                 FPassword = customer.FPassword,
                                 FBirthDate = customer.FBirthDate,
                                 FPoint = customer.FPoint,
                                 FBlackList = customer.FBlackList,
                                 FRemark = customer.FRemark,
                                 FCreationDate = customer.FCreationDate,
                                 FLastUpdateDate = customer.FLastUpdateDate
                             }).ToList();
                foreach (var item in datas)
                {
                    model.Add(new CCustomerViewModel()
                    {
                        FCustomerId = item.FCustomerId,
                        FLastName = item.FLastName,
                        FFirstName = item.FFirstName,
                        FGender = item.FGender,
                        FTel = item.FTel,
                        FMobile = item.FMobile,
                        FEmail = item.FEmail,
                        FPassword = item.FPassword,
                        FBirthDate = item.FBirthDate,
                        FPoint = item.FPoint,
                        FBlackList = item.FBlackList,
                        FRemark = item.FRemark,
                        FCreationDate = item.FCreationDate,
                        FLastUpdateDate = item.FLastUpdateDate
                    });
                }
                return View(model[0]);
            }
            return RedirectToAction("List");
        }
    }
}
