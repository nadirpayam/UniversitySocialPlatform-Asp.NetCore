using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.ViewComponents.Post
{
    public class PostLast3: ViewComponent
    {
        PostManager pm = new PostManager(new EFPostRepository());
        public IViewComponentResult Invoke()
        {
            var values = pm.GetLast3Post();
            return View(values);
        }
    }
}
