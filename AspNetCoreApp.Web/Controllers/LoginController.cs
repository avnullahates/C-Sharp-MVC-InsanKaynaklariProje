using AspNetCoreApp.Web.Models;
using BusinessLayer.ValidationRules;
using CoreLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Controllers
{
    [AllowAnonymous]

    public class LoginController : Controller
    {
        private readonly SignInManager<Personnel> _signInManager;
        private readonly UserManager<Personnel> _userManager;
        private readonly IPasswordHasher<Personnel> passwordHasher;

        public LoginController(SignInManager<Personnel> signInManager, UserManager<Personnel> userManager, IPasswordHasher<Personnel> passwordHasher)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            this.passwordHasher = passwordHasher;
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
                        return RedirectToAction("Index", "Personnel", user);
                    }
                    else
                    {
                        ViewBag.Message = "Kayıtlı Kullanıcı bulunamadı";
                        return View(userSign);
                    }
                }
                else
                {
                    ViewBag.Message = "Kayıtlı Kullanıcı bulunamadı";
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

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(PasswordVM passwordVM)
        {
            Personnel personnel = await _userManager.FindByEmailAsync(passwordVM.Email);

            if (personnel != null)
            {
                Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(personnel, passwordVM.OldPassword, false, false);
                if (result.Succeeded)
                {
                    if (passwordVM.NewPassword == passwordVM.ConfirmPassword)
                    {
                        personnel.PasswordHash = passwordHasher.HashPassword(personnel, passwordVM.NewPassword);
                        IdentityResult Iresult = await _userManager.UpdateAsync(personnel);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Message = "Şifre tekrarı hatalı";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Message = "Eski Şifre hatalı";
                    return View();
                }

            }
            else
            {
                ViewBag.Message = "Mail bulunamadı";
                return View();
            }
        }

        public async Task<IActionResult> NewPassword(PasswordVM passwordVM)
        {
            Personnel personnel = await _userManager.FindByEmailAsync(passwordVM.Email);
            if (personnel != null)
            {

                if (passwordVM.NewPassword == passwordVM.ConfirmPassword)
                {
                    personnel.PasswordHash = passwordHasher.HashPassword(personnel, passwordVM.NewPassword);
                    IdentityResult Iresult = await _userManager.UpdateAsync(personnel);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = "Şifre tekrarı hatalı";
                    return View();
                }

            }
            else
            {
                ViewBag.Message = "Mail bulunamadı";
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
