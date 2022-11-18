using AspNetCoreApp.Web.Models;
using BusinessLayer.Abstract;
using CoreLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Mvc;

namespace AspNetCoreApp.Web.Controllers
{
    public class ManagerController : Controller
    {
        private readonly UserManager<Personnel> userManager;
        private readonly IGenericService<Personnel> personnelService;
        private readonly IPersonnelService personnelManager;

        public ManagerController(UserManager<Personnel> userManager, IGenericService<Personnel> personnelService, IPersonnelService personnelManager)
        {
            this.userManager = userManager;
            this.personnelService = personnelService;
            this.personnelManager = personnelManager;
        }
        public IActionResult Index(int page=1)
        {
                PagedList<Personnel> personnels = (PagedList<Personnel>)personnelManager.GetAllPersonelsWithDepartment().ToPagedList(page, 4);
            return View(personnels);
        }
        [HttpPost]
        public IActionResult Index(string name, string surname,int page=1)
        {
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(surname))
            {
                PagedList<Personnel> personnels = (PagedList<Personnel>)personnelManager.GetAllPersonelsWithDepartment().ToPagedList(page, 4);
                return View(personnels);
            }
            if (name != null)
            {
                PagedList<Personnel> personnels = (PagedList<Personnel>)personnelManager.GetAllPersonelsWithDepartmentFilter(a => a.Name == name).ToPagedList(page, 4);
                return View(personnels);
            }
            if (name != null && surname != null)
            {
                PagedList<Personnel> personnels = (PagedList<Personnel>)personnelManager.GetAllPersonelsWithDepartmentFilter(a => a.Name == name && a.Surname == surname).ToPagedList(page, 4);
                return View(personnels);
            }
            if (surname != null)
            {
                PagedList<Personnel> personnels = (PagedList<Personnel>)personnelManager.GetAllPersonelsWithDepartmentFilter(a => a.Surname == surname).ToPagedList(page, 4);
                return View(personnels);
            }
            return View(null);
        }
        [HttpGet]
        public IActionResult CreatePersonnel()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePersonnel(UserSignUpViewModel userSignUp)
        {
            if (ModelState.IsValid)
            {
                Personnel personnel = new Personnel()
                {
                    Email = userSignUp.Name + "." + userSignUp.Surname + "@bilgeadamboost.com",
                    Name = userSignUp.Name,
                    Surname = userSignUp.Surname,
                    SecondSurname = userSignUp.SecondSurname,
                    MiddleName = userSignUp.MiddleName,
                    IdentityNumber = userSignUp.IdentityNumber,
                    Job = userSignUp.Job,
                    HireDate = userSignUp.HireDate,
                    Address = userSignUp.Address,
                    IsActive = true,
                    BirthDate = userSignUp.BirthDate,
                    DepartmentID = userSignUp.DepartmentID,

                };

                MailMessage mm = new MailMessage("john1996doe1996@gmail.com", userSignUp.Mail);
                mm.Subject = "Yeni Personel Ekleme";
                mm.Body = ""; //Sifre yenileme sayfasi gelecek.
                mm.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                NetworkCredential nc = new NetworkCredential("john1996doe1996@gmail.com", "saodzpcotcmhunho");
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Send(mm);
                ViewBag.Message = "Mail Başarıyla Gönderildi!";



                var result = await userManager.CreateAsync(personnel, userSignUp.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(userSignUp);
                }
            }
            else
            {
                ViewBag.Message = "Personel eklenemedi";
                return View(userSignUp);
            }
        }
    }
}
