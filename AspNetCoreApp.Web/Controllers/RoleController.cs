using CoreLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Controllers
{
    [Authorize(Roles = "admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<Personnel> userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<Personnel> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Required]string roleName)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await roleManager.CreateAsync(new IdentityRole(roleName));
                if (result.Succeeded)
                    return View();
                else
                    Error(result);
            }
            return View(roleName);
        }


        private void Error(IdentityResult result)
        {
            foreach (IdentityError err in result.Errors)
            {
                ModelState.AddModelError("Role Error", $"{err.Code}-{err.Description}");
            }
        }
    }


    
}
