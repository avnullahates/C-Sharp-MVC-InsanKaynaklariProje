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
    public class RegisterUserController : Controller
    {
        private readonly UserManager<Personnel> _userManager;

        public RegisterUserController(UserManager<Personnel> userManager)
        {
            _userManager = userManager;
        }
        //    [HttpGet]
        //    public IActionResult Index()
        //    {
        //        return View();
        //    }
        //    [HttpPost]
        //    public async Task<IActionResult> Index(UserSignUpViewModel userSign)
        //    {
        //        //PersonnelValidator validationRules = new PersonnelValidator();
        //        //ValidationResult rule = validationRules.Validate(userSign);



        //        if (ModelState.IsValid)
        //        {
        //            Personnel user = new Personnel()
        //            {
        //                BirthDate = new DateTime(2000, 01, 01),
        //                HireDate = new DateTime(2022, 01, 01),
        //                PlaceOfBirth = "Ankara",
        //                Gender = CoreLayer.Enums.Gender.Male,
        //                Job = "Yazılımcı",
        //                Name = userSign.Name,
        //                Surname = userSign.Surname,
        //                IdentityNumber = "12345678913",
        //                Email = userSign.Email,
        //                UserName = userSign.UserName
        //            };

        //            var result = await _userManager.CreateAsync(user, userSign.PasswordHash);

        //            if (result.Succeeded)
        //            {
        //                return RedirectToAction("Index", "Login");
        //            }
        //            else
        //            {
        //                foreach (var item in result.Errors)
        //                {
        //                    ModelState.AddModelError("", item.Description);
        //                }
        //            }
        //        }
        //        return View();
        //    }
    }
}
