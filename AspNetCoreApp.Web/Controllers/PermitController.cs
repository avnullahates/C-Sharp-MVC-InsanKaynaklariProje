using AspNetCoreApp.Web.Models;
using BusinessLayer.Abstract;
using CoreLayer.Entities;
using CoreLayer.VM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Controllers
{
    public class PermitController : Controller
    {
        private readonly IGenericService<Permit> _permitService;
        private readonly IGenericService<Personnel> _personelService;
        private readonly IPermitService _permitManager;
        private readonly UserManager<Personnel> _userManager;

        public PermitController(IGenericService<Permit> permitService, IGenericService<Personnel> personelService, IPermitService permitManager, UserManager<Personnel> userManager)
        {
            _permitService = permitService;
            _personelService = personelService;
            _permitManager = permitManager;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            Personnel personnel = await _userManager.GetUserAsync(HttpContext.User);
            var permits = _permitManager.GetListAllPermit(personnel.Id);
            return View(permits);
        }

        [HttpGet]
        public IActionResult Add()
        {
            PersonnelPermitVM vm = new PersonnelPermitVM();
            vm.Permit = new Permit();
            vm.Permit.StartDate = DateTime.Now;
            vm.Permit.EndDate = DateTime.Now.AddDays(1);
            TimeSpan ts = vm.Permit.EndDate - vm.Permit.StartDate;

            vm.Permit.PermitDay = ts.Days;
            vm.Personnels = _personelService.GetListAll();
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PersonnelPermitVM vm)
        {
            Personnel personnel = await _userManager.GetUserAsync(HttpContext.User);

            if (ModelState.IsValid)
            {
                Permit newPermit = new Permit()
                {
                    Status = true,
                    StartDate = vm.Permit.StartDate,
                    EndDate = vm.Permit.EndDate,
                    RequestDate = vm.Permit.RequestDate = DateTime.Now,
                    PermitDay = vm.Permit.EndDate.Day - vm.Permit.StartDate.Day,
                    Approval = CoreLayer.Enums.Approval.OnayBekliyor,
                    PermitTypes = vm.Permit.PermitTypes,
                    Description = vm.Permit.Description
                };

                if (vm.Permit.EndDate.Day - vm.Permit.StartDate.Day < 0)
                {
                    ViewBag.Message = "Başlangıç tarihi Bitiş tarihinden sonra olamaz!";
                    return View(vm);
                }
                if (vm.Permit.EndDate.Day - vm.Permit.StartDate.Day == 0)
                {
                    ViewBag.Message = "Başlangıç tarihi ve  Bitiş tarihi aynı olamaz!";
                    return View(vm);
                }
                else
                {
                    newPermit.PersonnelID = personnel.Id;
                    _permitService.Insert(newPermit);
                    return RedirectToAction("Index");
                }
            }
            else
            {
                ViewBag.Message = "İzin eklenemedi";
                vm.Personnels = _personelService.GetListAll();
                return View(vm);
            }
        }
        [HttpGet]
        public IActionResult PermDetails(int id)
        {
            Permit permit = _permitService.GetById(id);

            return View(permit);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            Permit permit = _permitService.GetById(id);

            PermitDTO permitDTO = new PermitDTO()
            {

                StartDate = permit.StartDate,
                EndDate = permit.EndDate,
                Description = permit.Description
            };

            return View(permitDTO);
        }

        [HttpPost]
        public IActionResult Edit(int id, PermitDTO permitDto)
        {
            Permit permit = _permitService.GetById(id);

            if (ModelState.IsValid)
            {
                permit.StartDate = permitDto.StartDate;
                permit.EndDate = permitDto.EndDate;
                permit.Description = permitDto.Description;
                permit.PermitDay = permit.EndDate.Day - permit.StartDate.Day;
                permit.RequestDate = DateTime.Now;

                if (permit.EndDate.Day - permit.StartDate.Day < 0)
                {
                    ViewBag.Message = "Başlangıç tarihi Bitiş tarihinden sonra olamaz!";
                    return View(permitDto);
                }
                if (permit.EndDate.Day - permit.StartDate.Day == 0)
                {
                    ViewBag.Message = "Başlangıç tarihi ve  Bitiş tarihi aynı olamaz!";
                    return View(permitDto);
                }
                else
                {
                    _permitService.Update(permit);
                    return RedirectToAction("Index");
                }
            }
            else
            {
                ViewBag.Message = "İzin Güncelleme Başarısız.";
                return View(permitDto);
            }

        }

        public IActionResult Delete(int id)
        {
            Permit permit = _permitService.GetById(id);
            return View(permit);
        }

        public IActionResult DeleteApprow(int id)
        {
            Permit permit = _permitService.GetById(id);

            _permitService.Remove(permit);
            return RedirectToAction("Index");
        }
    }
}
