using AspNetCoreApp.Web.Models;
using BusinessLayer.ValidationRules;
using CoreLayer.Entities;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AspNetCoreApp.Web.Controllers
{
    [AllowAnonymous]

    public class LoginController : Controller
    {
        
        private readonly SignInManager<Personnel> _signInManager;
        private readonly UserManager<Personnel> _userManager;
        private readonly IPasswordHasher<Personnel> passwordHasher;
        private readonly RoleManager<IdentityRole> roleManager;

        public LoginController(SignInManager<Personnel> signInManager, UserManager<Personnel> userManager, IPasswordHasher<Personnel> passwordHasher, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            this.passwordHasher = passwordHasher;
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel userSign)
        {

           

            if (ModelState.IsValid)
            {

                Personnel user = await _userManager.FindByEmailAsync(userSign.email);



                if (user != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, userSign.password, true, true);
                    if (result.Succeeded)
                    {
                        //bool role = await _userManager.IsInRoleAsync(user, "Personel"); bu var olan kullanıcının rolüyle beraber geliyor.

                        return RedirectToAction("Index", "Personnel", user);

                    }
                    else
                    {
                        ViewBag.Message = "Kullanıcı Adı veya Şifre hatalı";
                        return View(userSign);
                    }
                }
                else
                {
                    ViewBag.Message = "Kullanıcı Adı veya Şifre hatalı";
                    return View(userSign);
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        //Context db = new Context();

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(PasswordVM passwordVM)
        {
           
            Personnel personnel = await _userManager.FindByEmailAsync(passwordVM.Email);

            //var model = db.Users.FirstOrDefault(x => x.Email == passwordVM.Email);
            
            if (personnel != null)
            {
                Guid guid = Guid.NewGuid();
                string newPassword = guid.ToString().Substring(0, 8);
                passwordVM.NewPassword = newPassword;
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential("john1996doe1996@gmail.com", "saodzpcotcmhunho");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.To.Add(personnel.Email);
                mail.From = new MailAddress("john1996doe1996@gmail.com", "Şifre Yenileme");
                mail.IsBodyHtml = true;
                mail.Subject = "Şifre Sıfırlama";
                mail.Body += "Merhaba Sayın " + personnel.Name + " " + personnel.Surname + "<br/> Kullanıcı Adınız = " + personnel.Email + "<br/> Şifreniz: " + newPassword;
              
                client.Send(mail);
                personnel.PasswordHash = passwordHasher.HashPassword(personnel, passwordVM.NewPassword);
                IdentityResult Iresult = await _userManager.UpdateAsync(personnel);
                return RedirectToAction("Index");
               
            }
            else
            {
                ViewBag.Message = "Mail bulunamadı";
                return View(personnel);
            }









            //if (personnel != null)
            //{
            //    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(personnel, passwordVM.OldPassword, false, false);
            //    if (result.Succeeded)
            //    {
            //        if (passwordVM.NewPassword == passwordVM.ConfirmPassword)
            //        {
            //            personnel.PasswordHash = passwordHasher.HashPassword(personnel, passwordVM.NewPassword);
            //            IdentityResult Iresult = await _userManager.UpdateAsync(personnel);
            //            return RedirectToAction("Index");
            //        }
            //        else
            //        {
            //            ViewBag.Message = "Şifre tekrarı hatalı";
            //            return View();
            //        }
            //    }
            //    else
            //    {
            //        ViewBag.Message = "Eski Şifre hatalı";
            //        return View();
            //    }

            //}
            //else
            //{
            //    ViewBag.Message = "Mail bulunamadı";
            //    return View();
            //}
        }

        [HttpGet]
        public IActionResult NewPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewPassword(PasswordVM passwordVM,string id)
        {
            Personnel personnel = await _userManager.FindByIdAsync(id);

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(personnel, passwordVM.OldPassword, false, false);

            if (result.Succeeded)
            {
                

                if (passwordVM.NewPassword == passwordVM.ConfirmPassword)
                {
                    personnel.PasswordHash = passwordHasher.HashPassword(personnel, passwordVM.NewPassword);
                    IdentityResult Iresult = await _userManager.UpdateAsync(personnel);
                    return RedirectToAction("Details","Personnel");
                }
                else
                {
                    ViewBag.Message = "Şifre tekrarı hatalı";
                    return View();
                }

            }
            else
            {
                ViewBag.Message = "Eski şifre hatalı";
                return View();
            }
        }
    }
    //[HttpPost]
    //public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
    //{
    //    if (!ModelState.IsValid)
    //    {
    //        return View(model);
    //    }
    //    var user = await _userManager.FindByEmailAsync(model.Email);
    //    if (user == null)
    //    {
    //        return RedirectToAction("ResetPasswordConfirmation", "Account");
    //    }
    //    var result = await _userManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
    //    if (result.Succeeded)
    //    {
    //        return RedirectToAction("ResetPasswordConfirmation", "Account");
    //    }
    //    AddErrors(result);
    //    return View();
    //}



}
