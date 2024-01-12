using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace UniversitySocialPlatform.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AdminLoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        Context c = new Context();

        public AdminLoginController(SignInManager<AppUser> signInManager, Context c)
        {
            _signInManager = signInManager;
            this.c = c;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Adminim admin)
        {
            var result = await _signInManager.PasswordSignInAsync(admin.Username, admin.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Section", new { area = "Admin" });

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
