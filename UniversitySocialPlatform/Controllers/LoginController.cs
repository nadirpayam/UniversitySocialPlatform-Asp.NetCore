using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Controllers
{
    public class LoginController : Controller
    {
       
     
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Learner p)
        {
            Context c = new Context();
            var dataValue = c.Learners.FirstOrDefault(x => x.LearnerMail == p.LearnerMail
            && x.LearnerPassword == p.LearnerPassword);
            if (dataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.LearnerMail)
                };
                var learnerIdentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(learnerIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Learner");
            }
            else
            {
                return View();
            }
        }
    }
}
