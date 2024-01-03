using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Controllers
{
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
        public PartialViewResult PartialAddComment(Comment c)
        {
            c.CommentCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.CommentStatus = true;
            c.PostID = 1;
            cm.CommentAdd(c);
            return PartialView();
        }

        public PartialViewResult PartialCommentListByPost(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
