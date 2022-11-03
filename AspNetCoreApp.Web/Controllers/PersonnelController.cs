using BusinessLayer.Concrete;
using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Controllers
{
    public class PersonnelController : Controller
    {

        private readonly IGENERICDAL<Personnel> _personnelContext;

        public PersonnelController(IGENERICDAL<Personnel> personnelContext)
        {
            _personnelContext = personnelContext;
        }

        public IActionResult Index()
        {

            var personnel = _personnelContext.GetById(2);
            int age =(int)DateTime.Now.Year - personnel.BirthDate.Year;
            if (personnel.Gender == CoreLayer.Enums.Gender.Male)
            {
                ViewBag.gender = "~/images/man_default.png";
            }
            else
            {
                ViewBag.gender = "~/images/woman_default.png";
            }



            return View(personnel);
        }

    }
}
