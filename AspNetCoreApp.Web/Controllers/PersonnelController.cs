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
            var personnel = _personnelContext.GetById(4);
            return View(personnel);
        }

    }
}
