using BusinessLayer.Abstract;
using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Controllers
{
    public class AdvanceController : Controller
    {
        private readonly IGenericService<Advance> _advanceService;
        public AdvanceController(IGenericService<Advance> advanceService)
        {
            _advanceService = advanceService;
        }
        public IActionResult Index()
        {
            var advance = _advanceService.GetListAll();
            return View(advance);
        }

        [HttpGet]
        public IActionResult Add()
        {
            Advance advance = new Advance();
            return View(advance);
        }

        [HttpPost]
        public IActionResult Add(Advance advance)
        {
            ViewBag.personelID = 4;
            advance.Approval = CoreLayer.Enums.Approval.OnayBekliyor;
            advance.Currency = CoreLayer.Enums.Currency.TL;
            var newAdvance = _advanceService.Insert(advance);
            return RedirectToAction("Index");
        }
    }
}
