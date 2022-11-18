using AspNetCoreApp.Web.Models;
using BusinessLayer.Concrete;
using CoreLayer.Entities;
using CoreLayer.VM;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Controllers
{
    [Route("EasyHR/[controller]/[action]/Bilgiler")]
    public class PersonnelController : Controller
    {

        private readonly IGENERICDAL<Personnel> _personnelContext;
        private readonly IGENERICDAL<Advance> advanceRepo;
        private readonly UserManager<Personnel> _userManager;

        public PersonnelController(IGENERICDAL<Personnel> personnelContext, IGENERICDAL<Advance> advanceRepo, UserManager<Personnel> userManager)
        {
            _personnelContext = personnelContext;
            this.advanceRepo = advanceRepo;
            _userManager = userManager;
        }

        //[Authorize]
        [HttpGet]
        
        public async Task<IActionResult> Index(string id)
        {
            Personnel personel = await _userManager.FindByIdAsync(id);
            TempData["Invoce"] = personel.ImagePath;
            return View(personel);
        }

        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {

            Personnel personnel = await _userManager.FindByIdAsync(id);
            PersonnelVM personnelVM = new PersonnelVM();
            personnelVM.PhoneNumber=personnel.PhoneNumber;
            personnelVM.Address = personnel.Address;

            //Personnel personnel = await _userManager.GetUserAsync(HttpContext.User);
            return View(personnelVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(string id, PersonnelVM personnelVM)
        {
            Personnel personnel = await _userManager.FindByIdAsync(id);
            if (ModelState.IsValid)
            {
                personnel.PhoneNumber = personnelVM.PhoneNumber;
                personnel.Address = personnelVM.Address;
                
                if(personnelVM.ImagePath != null)
                {
                    var imageExtension = Path.GetExtension(personnelVM.ImagePath.FileName);
                    var newImageName = Guid.NewGuid() + imageExtension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    await personnelVM.ImagePath.CopyToAsync(stream);

                    personnel.ImagePath=newImageName;
                }

                IdentityResult result = await _userManager.UpdateAsync(personnel);
                if (result.Succeeded)
                    return RedirectToAction("Index", personnelVM);
            }
            else
            {
                ModelState.AddModelError("Update", "Güncelleme işlemi başarısız!");
            }
            return View(personnel);
        }



        public async Task<IActionResult> Details()
        {
            Personnel personnel = await _userManager.GetUserAsync(HttpContext.User);
            return View(personnel);
        }

      


    }
}
