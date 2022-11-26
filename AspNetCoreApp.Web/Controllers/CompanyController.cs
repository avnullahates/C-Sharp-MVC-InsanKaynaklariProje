using AspNetCoreApp.Web.Models;
using BusinessLayer.Abstract;
using CoreLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IGenericService<Company> _genericService;
        private readonly ICompanyService _companyService;

        public CompanyController(IGenericService<Company> genericService, ICompanyService companyService)
        {
            _genericService = genericService;
            _companyService = companyService;
        }
        public IActionResult Index()
        {
            var companies = _companyService.GetListAllCompanies();
            return View(companies);
        }
        [HttpGet]
        public IActionResult AddCompany()
        {
            CompanyVM companyVM = new CompanyVM();
            return View(companyVM);
        }
        [HttpPost]
        public IActionResult AddCompany(CompanyVM companyVM)
        {
            if (ModelState.IsValid)
            {
                Company company = new Company();
                company.ID = companyVM.ID;
                company.Name = companyVM.Name;
                company.Mail = companyVM.Mail;
                company.PhoneNumber = companyVM.PhoneNumber;
                //company.LogoPath = companyVM.LogoPath;
                company.CompanyType = companyVM.CompanyType;
                company.Address = companyVM.Address;

                _genericService.Insert(company);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Şirket eklenemedi!";
                return View(companyVM);
            }
        }
    }
}
