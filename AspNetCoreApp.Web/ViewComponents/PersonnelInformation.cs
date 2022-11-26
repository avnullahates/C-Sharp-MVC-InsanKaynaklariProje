using CoreLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.ViewComponents
{
    public class PersonnelInformation : ViewComponent
    {
    
        private readonly UserManager<Personnel> _userManager;

        public PersonnelInformation( UserManager<Personnel> userManager)
        {
           
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            Personnel personel = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = personel.Name + " " + personel.Surname;
            TempData["Invoce"] = personel.ImagePath;
            return View(personel);
        }
    }
}
