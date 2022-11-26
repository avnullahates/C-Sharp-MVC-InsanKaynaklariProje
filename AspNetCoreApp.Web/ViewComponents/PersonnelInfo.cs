using CoreLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AspNetCoreApp.Web.ViewComponents
{
    public class PersonnelInfo : ViewComponent
    {

        private readonly UserManager<Personnel> _userManager;

        public PersonnelInfo(UserManager<Personnel> userManager)
        {

            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            Personnel personel = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = personel.Name + " " + personel.Surname;
            TempData["Invoce"] = personel.ImagePath;
            string api = "0563aff1b5fcd3d1e4e8d373d7f31ddb";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Istanbul&mode=xml&land=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View(personel);


        }
    
    }
}
