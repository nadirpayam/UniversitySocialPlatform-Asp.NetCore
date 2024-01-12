using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();

            var learnerId = c.Learners.Where(x => x.LearnerMail == usermail).Select(x => x.LearnerID).FirstOrDefault();
            
            
            ViewBag.Postlar = c.Posts.Count().ToString();
            ViewBag.LearnerPost = c.Posts.Where(x => x.LearnerID == learnerId).Count();
            ViewBag.Sections = c.Sections.Count();
            return View();
        }
    }
}
