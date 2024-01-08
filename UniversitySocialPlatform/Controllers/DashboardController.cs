using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.Postlar = c.Posts.Count().ToString();
            ViewBag.LearnerPost = c.Posts.Where(x => x.LearnerID == 1).Count();
            ViewBag.Sections = c.Sections.Count();
            return View();
        }
    }
}
