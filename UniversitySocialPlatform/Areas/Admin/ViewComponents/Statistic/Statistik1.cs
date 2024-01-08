using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Areas.Admin.ViewComponents.Statistic
{
    public class Statistik1: ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.PostCount = c.Posts.Count();
            ViewBag.ContactCount = c.Contacts.Count();
            ViewBag.CommentCount = c.Comments.Count();
            return View();
        }
    }
}
