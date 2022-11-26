using AspNetCoreApp.Web.Models;
using BusinessLayer.Abstract;
using CoreLayer.Entities;
using CoreLayer.VM;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Controllers
{
    [Authorize(Roles = "Personel,Manager")]
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
            var sumAdvance = advanceManager.SumAdvance(personnel.Id);
            decimal? dif = personnel.Salary - sumAdvance;
            ViewBag.sumAdvance = sumAdvance;
            ViewBag.difAdvance = dif;
            vm.Personnels = _personnelService.GetListAll();
            return View(vm);


        }



        [HttpPost]
        public async Task<IActionResult> Add(PersonnelAdvanceVM vm)
        {
            Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
            if (ModelState.IsValid)
            {
                Advance newAdvance = new Advance()
                {
                    AdvanceAmount = vm.Advance.AdvanceAmount,
                    CreationDate = vm.Advance.CreationDate,
                    Approval = CoreLayer.Enums.Approval.OnayBekliyor,
                    Currency = vm.Advance.Currency,
                    Description = vm.Advance.Description

                };
                newAdvance.PersonnelID = personnel.Id;


                var sumAdvance = advanceManager.SumAdvance(personnel.Id);
                decimal? dif = personnel.Salary - sumAdvance;
                ViewBag.sumAdvance = sumAdvance;
                ViewBag.difAdvance = dif;

                if (vm.Advance.AdvanceAmount <= dif)
                {
                    _advanceService.Insert(newAdvance);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = " Bu yıl ki toplam Avans Miktarı, Toplam Maaşı geçmiştir";
                    vm.Personnels = _personnelService.GetListAll();
                    return View(vm);
                }



            }

            else
            {
                ViewBag.Message = "Avans eklenemedi";
                vm.Personnels = _personnelService.GetListAll();
                return View(vm);
            }


        }
        [HttpGet]
        public async Task<IActionResult> UpdateAdvance(int id)
        {
            Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
            AdvanceVM advanceVM = new AdvanceVM();
            Advance advance = _advanceService.GetById(id);

            advanceVM.AdvanceAmount = advance.AdvanceAmount;
            advanceVM.Currency = advance.Currency;
            advanceVM.Description = advance.Description;

            return View(advanceVM);
        }
        [HttpPost]
        public IActionResult UpdateAdvance(AdvanceVM advanceVM, int id)
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
        [HttpGet]
        public async Task<IActionResult> AdvanceDetails(int id)
        {
            Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
            Advance advance = _advanceService.GetById(id);
            return View(advance);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Advance advance = _advanceService.GetById(id);
            return View(advance);
        }
        [HttpPost]
        public IActionResult DeleteAdvance(int id)
        {
            Advance advance = _advanceService.GetById(id);

            if (advance.Approval == CoreLayer.Enums.Approval.OnayBekliyor)
            {
                _advanceService.Remove(advance);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Sadece onay bekleyen avans silinebilir!";
                return View(advance);
            }

        }
    }

}
