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
    public class Statistik2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.LastPost = c.Posts.OrderByDescending(x=>x.PostID).Select(x=>x.PostTitle).Take(1).FirstOrDefault();
            ViewBag.CommentCount = c.Comments.Count();
            return View();
        }
    }
}
