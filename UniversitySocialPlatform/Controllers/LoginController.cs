using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UniversitySocialPlatform.Models;

namespace UniversitySocialPlatform.Controllers
{
  [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        Context c = new Context();

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, false);
            if (result.Succeeded)
            {
                var username = User.Identity.Name;
                var learnerMail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
                var learnerName = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerName).FirstOrDefault();
              
                var learnerSurname = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerSurname).FirstOrDefault();
             
                var type = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerTypeID).FirstOrDefault();
                var learnerUnvan = c.LearnerTypes.Where(x => x.LearnerTypeID == type).Select(x => x.LearnerTypeName).FirstOrDefault();

                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
           
        }
    
    
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    
    
    }
}
