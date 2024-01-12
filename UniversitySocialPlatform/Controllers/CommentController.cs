using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult PartialAddComment(Comment c, int id)
        {
            c.CommentCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.CommentStatus = true;
            c.PostID = id;
            cm.CommentAdd(c);
            return RedirectToAction("Index","Post");
        }

        public PartialViewResult PartialCommentListByPost(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
