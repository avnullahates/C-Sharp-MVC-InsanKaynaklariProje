using AspNetCoreApp.Web.Models;
using BusinessLayer.Abstract;
using CoreLayer.Entities;
using CoreLayer.VM;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Identity;
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
        private readonly IGenericService<Personnel> _personnelService;
        private readonly UserManager<Personnel> userManager;
        private readonly IAdvanceService advanceManager;

        public AdvanceController(IGenericService<Advance> advanceService, IGenericService<Personnel> personnelService, UserManager<Personnel> userManager, IAdvanceService advanceManager)
        {
            _advanceService = advanceService;
            _personnelService = personnelService;
            this.userManager = userManager;
            this.advanceManager = advanceManager;

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
            var advances = advanceManager.GetListAllAdvance(personnel.Id);
            TempData["Invoce"] = personnel.ImagePath;
            return View(advances);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
            TempData["Invoce"] = personnel.ImagePath;

            PersonnelAdvanceVM vm = new PersonnelAdvanceVM();
            vm.Advance = new Advance();

            vm.Personnels = _personnelService.GetListAll();
            return View(vm);

            
        }

        [HttpPost]
        public IActionResult Add(PersonnelAdvanceVM vm)
        {
            Advance newAdvance = new Advance()
            {
                AdvanceAmount = vm.Advance.AdvanceAmount,
                CreationDate = vm.Advance.CreationDate,
                Approval = CoreLayer.Enums.Approval.OnayBekliyor,

                Currency = vm.Advance.Currency,
                Description = vm.Advance.Description,

                PersonnelID = vm.Advance.PersonnelID

            };
            if (ModelState.IsValid)
            {
                _advanceService.Insert(newAdvance);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Avans eklenemedi";
                vm.Personnels = _personnelService.GetListAll();
                return View(vm);
            }


        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            

            AdvanceVM advanceVM = new AdvanceVM();
            Advance advance = _advanceService.GetById(id);

            advanceVM.AdvanceAmount = advance.AdvanceAmount;
            advanceVM.Currency = advance.Currency;
            advanceVM.Description = advance.Description;

            return View(advanceVM);
        }
        [HttpPost]
        public IActionResult Update(AdvanceVM advanceVM, int id)
        {
            if (ModelState.IsValid)
            {
                Advance advance = _advanceService.GetById(id);
                advance.AdvanceAmount = advanceVM.AdvanceAmount;
                advance.Description = advanceVM.Description;
                advance.Currency = advanceVM.Currency;

                var result = _advanceService.Update(advance);

                return RedirectToAction("Index", result);
            }
            else
            {
                ModelState.AddModelError("Update", "Güncelleme işlemi başarısız!");
            }
            return View(advanceVM);
        }
    }

}
