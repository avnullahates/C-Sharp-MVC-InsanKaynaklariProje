using AspNetCoreApp.Web.Models;
using BusinessLayer.Abstract;
using CoreLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<Personnel> userManager;
        private readonly IGenericService<Personnel> personnelService;
        private readonly IPersonnelService personnelManager;
        private readonly IGenericService<Department> departmentService;
        private readonly IPasswordHasher<Personnel> passwordHasher;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IGenericService<Company> companyService;
        private readonly ICompanyService companyManager;

        public AdminController(UserManager<Personnel> userManager,  IGenericService<Personnel> personnelService, IPersonnelService personnelManager, IGenericService<Department> departmentService, IPasswordHasher<Personnel> passwordHasher, RoleManager<IdentityRole> roleManager, IGenericService<Company> companyService,ICompanyService companyManager)
        {
            this.userManager = userManager;
            this.personnelService = personnelService;
            this.personnelManager = personnelManager;
            this.departmentService = departmentService;
            this.passwordHasher = passwordHasher;
            this.roleManager = roleManager;
            this.companyService = companyService;
            this.companyManager = companyManager;
        }
        public async Task<IActionResult> Index()
        {
            //Company company=companyManager.GetAllPersonelsWithCompany(id);
            //return View(company);
            
            List<Personnel> Personnels = (List<Personnel>)await userManager.GetUsersInRoleAsync("Manager");
            
            return View(Personnels);
            
        }

        public IActionResult ListCompanies()
        {
            var companies = companyService.GetListAll();
            return View(companies);

        }
        [HttpGet]
        public IActionResult AddCompany()
        {
            CompanyVM companyVM = new CompanyVM();
            return View(companyVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddCompany(CompanyVM companyVM)
        {
            if (ModelState.IsValid)
            {
                Company company = new Company();
                company.ID = companyVM.ID;
                company.Name = companyVM.Name;

                companyVM.Name = companyVM.Name.Trim().Replace(" ",string.Empty);
                companyVM.Name = companyVM.Name.ToLower();
                company.Mail = "info@" + companyVM.Name + ".com";
                company.PhoneNumber = companyVM.PhoneNumber;
                company.CompanyType = companyVM.CompanyType;
                company.Address = companyVM.Address;

                if (companyVM.LogoPath != null)
                {
                    var imageExtension = Path.GetExtension(companyVM.LogoPath.FileName);
                    var newImageName = Guid.NewGuid() + imageExtension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Logo/", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    await companyVM.LogoPath.CopyToAsync(stream);

                    company.LogoPath = newImageName;
                }

                companyService.Insert(company);
                return RedirectToAction("ListCompanies");
            }
            else
            {
                ViewBag.Message = "Şirket eklenemedi!";
                return View(companyVM);
            }
        }

        [HttpGet]
        public IActionResult CreateManager()
        {
            UserSignUpViewModel userSignUp = new UserSignUpViewModel();
            userSignUp.Departments = departmentService.GetListAll();
            return View(userSignUp);
        }

        [HttpPost]
        public async Task<IActionResult> CreateManager(UserSignUpViewModel userSignUp,int id)
        {
            Company company = companyService.GetById(id);

            if (ModelState.IsValid)
            {
                Personnel personnel = new Personnel();

                personnel.Email = userSignUp.Name.ToLower().Trim().Replace(" ", string.Empty) + "." + userSignUp.Surname.ToLower().Trim().Replace(" ", string.Empty) +"@"+ company.Name.ToLower().Trim().Replace(" ", string.Empty) + ".com";
                personnel.Name = userSignUp.Name;
                personnel.Surname = userSignUp.Surname;
                personnel.SecondSurname = userSignUp.SecondSurname;
                personnel.MiddleName = userSignUp.MiddleName;
                personnel.IdentityNumber = userSignUp.IdentityNumber;
                personnel.Job = userSignUp.Job;
                personnel.HireDate = userSignUp.HireDate;
                personnel.Address = userSignUp.Address;
                personnel.IsActive = true;
                personnel.BirthDate = userSignUp.BirthDate;
                personnel.DepartmentID = userSignUp.DepartmentID;
                personnel.PhoneNumber = userSignUp.PhoneNumber;
                personnel.Gender = userSignUp.Gender;
                personnel.UserName = personnel.Email;
                personnel.PlaceOfBirth = userSignUp.PlaceOfBirth;
                personnel.CompanyID = company.ID;

                string Role = "Manager";

                Guid guid = Guid.NewGuid();
                string newPassword = guid.ToString().Substring(0, 8);
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential("john1996doe1996@gmail.com", "saodzpcotcmhunho");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.To.Add(personnel.Email);
                mail.From = new MailAddress("john1996doe1996@gmail.com", "Yeni Şifre");
                mail.IsBodyHtml = true;
                mail.Subject = "Yeni Şifre";

                mail.Body += "Merhaba Sayın " + personnel.Name + " " + personnel.Surname + "<br/> Kullanıcı Adınız = " + personnel.Email + "<br/> Şifreniz: " + newPassword + "<br/>Giriş Yapmak için tıklayınız:" + "https://aspnetcoreappweb20221113160658.azurewebsites.net/";
                


                client.Send(mail);


                var result = await userManager.CreateAsync(personnel, newPassword);


                if (result.Succeeded)
                {

                    IdentityResult rslt = await userManager.AddToRoleAsync(personnel, Role);
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ViewBag.Message = "Şirket Yöneticisi eklenemedi";
                    userSignUp.Departments = departmentService.GetListAll();
                    return View(userSignUp);
                }

            }
            else
            {
                ViewBag.Message = "Şirket Yöneticisi eklenemedi";
                userSignUp.Departments = departmentService.GetListAll();
                return View(userSignUp);
            }
        }

        
    }
}
