using AspNetCoreApp.Web.Models;
using BusinessLayer.Abstract;
using CoreLayer.Entities;
using CoreLayer.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Controllers
{
    [Authorize(Roles = "Personel,Manager")]
    public class ExpenseController : Controller
    {
        private readonly IGenericService<Expense> expenceService;
        private readonly UserManager<Personnel> userManager;
        private readonly IExpenseService expenseManager;
        private readonly IGenericService<Personnel> personelService;

        public ExpenseController(IGenericService<Expense> expenceService,UserManager<Personnel> userManager,IExpenseService expenseManager, IGenericService<Personnel> personelService)
        {
            this.expenceService = expenceService;
            this.userManager = userManager;
            this.expenseManager = expenseManager;
            this.personelService = personelService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            FilterExpenseVM filterExpenseVM = new FilterExpenseVM();
            Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
            filterExpenseVM.Expenses = expenseManager.GetListAllExpense(personnel.Id);
            TempData["Invoce"] = personnel.ImagePath;
            return View(filterExpenseVM);
        }

        [HttpPost]
        public async Task<IActionResult> Index(FilterExpenseVM filterExpenseVM)
        {
            Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
            if ((int)filterExpenseVM.TypeOfExpenses != 0)
            {

                filterExpenseVM.Expenses = expenceService.GetDefault(a => a.TypeOfExpenses == filterExpenseVM.TypeOfExpenses && a.PersonnelID==personnel.Id);
                return View(filterExpenseVM);
            }
            else
            {
                ModelState.AddModelError("", "Gider seçimi zorunludur!");
               
                filterExpenseVM.Expenses = expenseManager.GetListAllExpense(personnel.Id);
                return View(filterExpenseVM);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
            TempData["Invoce"] = personnel.ImagePath;
            ExpenseDTO expenseDTO = new ExpenseDTO();
            return View(expenseDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ExpenseDTO expenseDTO)
        {
            Personnel personnel = await userManager.GetUserAsync(HttpContext.User);

            if (ModelState.IsValid)
            {
                Expense expense = new Expense()
                {
                    ExpenseAmount = expenseDTO.ExpenseAmount,
                    TypeOfExpenses = expenseDTO.TypeOfExpenses,
                    Description = expenseDTO.Description,
                    Currency = expenseDTO.Currency,
                };

                if (expenseDTO.Invoce != null)
                {
                    var imageExtension = Path.GetExtension(expenseDTO.Invoce.FileName);
                    var newImageName = Guid.NewGuid() + imageExtension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files/Invoices", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    await expenseDTO.Invoce.CopyToAsync(stream);

                    expense.Invoce = newImageName;
                }
                expense.PersonnelID = personnel.Id;
                expenceService.Insert(expense);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Gider eklenemedi";
                return View(expenseDTO);
            }
        }

        [HttpGet]
        public async Task<IActionResult> ExpenseDetails(int id)
        {
            Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
            TempData["Invoce"] = personnel.ImagePath;

            Expense expense = expenceService.GetById(id);
            return View(expense);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateExpense(int id)
        {
            Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
            TempData["Invoce"] = personnel.ImagePath;

            Expense expense = expenceService.GetById(id);
            ExpenseDTO expenseDTO = new ExpenseDTO()
            {
                ExpenseAmount = expense.ExpenseAmount,
                TypeOfExpenses = expense.TypeOfExpenses,
                Currency = expense.Currency,
                Description = expense.Description,
                Approval=expense.Approval,
                
            };
            return View(expenseDTO);
          
        }

        [HttpPost]
        public async Task<IActionResult> UpdateExpense(int id,ExpenseDTO expenseDTO)
        {
            Expense expense = expenceService.GetById(id);
            if (ModelState.IsValid)
            {
                if (expense.Approval == Approval.OnayBekliyor)
                {
                    expense.CreationDate=DateTime.Now;
                    expense.ExpenseAmount=expenseDTO.ExpenseAmount;
                    expense.TypeOfExpenses=expenseDTO.TypeOfExpenses;
                    expense.Currency=expenseDTO.Currency;
                    expense.Description=expenseDTO.Description;
                    if (expenseDTO.Invoce != null)
                    {
                        var dosyaYolu = Path.GetFileName(expenseDTO.Invoce.FileName);
                        var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files/Invoices/", dosyaYolu);
                        var stream = new FileStream(location, FileMode.Create);
                        await stream.CopyToAsync(stream);

                        expense.Invoce = dosyaYolu;
                    }
                    expenceService.Update(expense);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = "Sadece Onay bekleyen Giderler için değişiklik yapabilirsiniz.";
                    return View(expenseDTO);
                }
            }
            else
            {
                ViewBag.Message = " Gider Güncellenemedi";
                return View(expenseDTO);
            }
        }
        public IActionResult Delete(int id)
        {
            Expense expense = expenceService.GetById(id);
            return View(expense);
        }
        public IActionResult DeleteApprow(int id)
        {
            Expense expense = expenceService.GetById(id);
            if (expense.Approval == Approval.OnayBekliyor)
            {
                expenceService.Remove(expense);
                return RedirectToAction("Index");
            }   
            else
            {
                ViewBag.Message = "Sadece Onay bekleyen Gider silinebilir..";
                return View(expense);
            }

        }

        //[HttpGet]
        //public async Task<IActionResult> FilterExpense()
        //{
        //    FilterExpenseVM filterExpenseVM = new FilterExpenseVM();
        //    Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
        //    filterExpenseVM.Expenses= expenseManager.GetListAllExpense(personnel.Id);
        //    return View(filterExpenseVM);
        //}

        //[HttpPost]
        //public async Task<IActionResult> FilterExpense(FilterExpenseVM filterExpenseVM)
        //{    
        //    if(filterExpenseVM.TypeOfExpenses!=null)
        //    {
                
        //        filterExpenseVM.Expenses = expenceService.GetDefault(a => a.TypeOfExpenses==filterExpenseVM.TypeOfExpenses);
        //        return View(filterExpenseVM);
        //    }
        //    else
        //    {
               
        //        Personnel personnel = await userManager.GetUserAsync(HttpContext.User);
        //        filterExpenseVM.Expenses = expenseManager.GetListAllExpense(personnel.Id);
        //        return View(filterExpenseVM);
        //    }
            
        //}

    }
}
