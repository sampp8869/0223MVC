using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;

namespace FinalProject.Controllers
{
	public class ProductController : SuperController
	{
		private readonly FinalProjectContext _context;
        IWebHostEnvironment _environment;

        public ProductController(FinalProjectContext context, IWebHostEnvironment p)
		{
            _environment = p;
			_context = context;
		}
		public IActionResult List()
		{
            List<CProductViewModel> model = new List<CProductViewModel>();
            var datas = (from product in _context.TProduct
                         join period in _context.TPeriod on product.FPeriodId equals period.FId
                         join provider in _context.TProvider on product.FProviderId equals provider.FId
                         where !product.FRemoved
                         select new
                         {
                             FId = product.FId,
                             FName = product.FName,
                             FPeriod = period.FDescription,
                             FProvider = provider.FCompanyName,
                             FCost = product.FCost,
                             FPrice = product.FPrice,
                             FImagePath = product.FImagePath
                         }).ToList();
            foreach(var item in datas)
            {
                model.Add(new CProductViewModel()
                {
                    FId = item.FId,
                    FName = item.FName,
                    FPeriod = item.FPeriod,
                    FProvider = item.FProvider,
                    FCost = item.FCost,
                    FPrice = item.FPrice,
                    FImagePath = item.FImagePath
                });
            }
			return View(model);
		}

        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                List<CProductViewModel> model = new List<CProductViewModel>();
                var datas = (from product in _context.TProduct
                             join period in _context.TPeriod on product.FPeriodId equals period.FId
                             join provider in _context.TProvider on product.FProviderId equals provider.FId
                             where product.FId == id
                             select new
                             {
                                 FId = product.FId,
                                 FName = product.FName,
                                 FPeriod = period.FDescription,
                                 FCost = product.FCost,
                                 FPrice = product.FPrice,
                                 FStocks = product.FStocks,
                                 FDescription = product.FDescription,
                                 FImagePath = product.FImagePath,
                                 FMinParticipants = product.FMinParticipants,
                                 FMaxParticipants = product.FMaxParticipants,
                                 FAssemblyPoint = product.FAssemblyPoint,
                                 FStartDate = product.FStartDate,
                                 FEndDate = product.FEndDate,
                                 FProvider = provider.FCompanyName,
                                 FRemark = product.FRemark,
                                 FCreationDate = product.FCreationDate,
                                 FLastUpdateDate = product.FLastUpdateDate
                             }).ToList();
                foreach (var item in datas)
                {
                    model.Add(new CProductViewModel()
                    {
                        FId = item.FId,
                        FName = item.FName,
                        FPeriod = item.FPeriod,
                        FCost = item.FCost,
                        FPrice = item.FPrice,
                        FStocks = item.FStocks,
                        FDescription = item.FDescription,
                        FImagePath = item.FImagePath,
                        FMinParticipants = item.FMinParticipants,
                        FMaxParticipants = item.FMaxParticipants,
                        FAssemblyPoint = item.FAssemblyPoint,
                        FStartDate = item.FStartDate,
                        FEndDate = item.FEndDate,
                        FProvider = item.FProvider,
                        FRemark = item.FRemark,
                        FCreationDate = item.FCreationDate,
                        FLastUpdateDate = item.FLastUpdateDate
                    });
                }
                return View(model[0]);
            }
            return RedirectToAction("List");
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CProductViewModel vm)
        {
            TProduct p = new TProduct();
            if (vm.photo != null)
            {
                string photoName = Guid.NewGuid().ToString() + ".jpg";
                string path = _environment.WebRootPath + "/images/" + photoName;
                p.FImagePath = photoName;
                vm.photo.CopyTo(new FileStream(path, FileMode.Create));
            }
            p.FName = vm.FName;
            p.FPeriodId = vm.FPeriodId;
            p.FCost = vm.FCost;
            p.FPrice = vm.FPrice;
            p.FStocks = vm.FStocks;
            p.FDescription = vm.FDescription;
            p.FMinParticipants = vm.FMinParticipants;
            p.FMaxParticipants = vm.FMaxParticipants;
            p.FAssemblyPoint = vm.FAssemblyPoint;
            p.FStartDate = vm.FStartDate;
            p.FEndDate = vm.FEndDate;
            p.FProviderId = vm.FProviderId;
            p.FRemark = vm.FRemark;
            p.FRemoved = false;
            p.FCreationDate = DateTime.Now;
            p.FLastUpdateDate = DateTime.Now;
            _context.TProduct.Add(p);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                TProduct RemovedProduct = _context.TProduct.FirstOrDefault(t => t.FId == id);
                if (RemovedProduct != null)
                {
                    RemovedProduct.FRemoved = true;
                    _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("List");
        }
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                TProduct p = _context.TProduct.FirstOrDefault(t => t.FId == id);
                if (p != null)
                {
                    CProductViewModel vm = new CProductViewModel();
                    vm.FId = p.FId;
                    vm.FName = p.FName;
                    vm.FPeriodId = p.FPeriodId;
                    vm.FCost = p.FCost;
                    vm.FPrice = p.FPrice;
                    vm.FStocks = p.FStocks;
                    vm.FDescription = p.FDescription;
                    vm.FImagePath = p.FImagePath;
                    vm.FMinParticipants = p.FMinParticipants;
                    vm.FMaxParticipants = p.FMaxParticipants;
                    vm.FAssemblyPoint = p.FAssemblyPoint;
                    vm.FStartDate = p.FStartDate;
                    vm.FEndDate = p.FEndDate;
                    vm.FProviderId = p.FProviderId;
                    vm.FRemark = p.FRemark;
                    vm.FCreationDate = p.FCreationDate;
                    vm.FLastUpdateDate = p.FLastUpdateDate;
                    return View(vm);
                }
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Edit(CProductViewModel vm)
        {
            TProduct p = _context.TProduct.FirstOrDefault(t => t.FId == vm.FId);
            if (p != null)
            {
                if (vm.photo != null)
                {
                    string photoName = Guid.NewGuid().ToString() + ".jpg";
                    string path = _environment.WebRootPath + "/images/" + photoName;
                    p.FImagePath = photoName;
                    vm.photo.CopyTo(new FileStream(path, FileMode.Create));
                }
                p.FName = vm.FName;
                p.FCost = vm.FCost;
                p.FPrice = vm.FPrice;
                p.FStocks = vm.FStocks;
                p.FDescription = vm.FDescription;
                p.FMinParticipants = vm.FMinParticipants;
                p.FMaxParticipants = vm.FMaxParticipants;
                p.FAssemblyPoint = vm.FAssemblyPoint;
                p.FStartDate = vm.FStartDate;
                p.FEndDate = vm.FEndDate;
                p.FRemark = vm.FRemark;
                p.FLastUpdateDate = DateTime.Now;
                _context.SaveChangesAsync();
            }
            return RedirectToAction("List");
        }
    }
}
