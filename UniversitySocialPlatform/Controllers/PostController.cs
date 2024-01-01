using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Controllers
{
    public class PostController : Controller
    {
        PostManager pm = new PostManager(new EFPostRepository());
        public IActionResult Index()
        {
            var values = pm.GetListWithSectionLearner();
            return View(values);
        }

        public IActionResult PostReadAll(int id)
        {
            var values = pm.GetPostById(id);
            return View(values);
        }
    }
}
