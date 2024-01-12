using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataAccessLayer.Concrete;
using UniversitySocialPlatform.Models;
using System.IO;

namespace UniversitySocialPlatform.Controllers
{
   
    [AllowAnonymous]
    public class PostController : Controller
    {
        PostManager pm = new PostManager(new EFPostRepository());
        SectionManager sm = new SectionManager(new EFSectionRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var values = pm.GetListWithSectionLearner();
            return View(values);
        }

        public IActionResult ListBySectionId(int id)
        {
            var values = pm.GetListWithSectionLearnerSectionID(id);
            return View("Index",values);
        }

        public IActionResult PostReadAll(int id)
        {
            ViewBag.PostId = id;
            var values = pm.GetPostById(id);
            ViewBag.lastPost = id;
            return View(values);
        }

        public IActionResult PostListByLearner()
        {
            var username = User.Identity.Name;
            var learnerMail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var learnerID = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerID).FirstOrDefault();
            var values = pm.GetListWithSectionByLearnerPm(learnerID);
            return View(values);
        }

        [HttpGet]
        public IActionResult PostAdd()
        {
            List<SelectListItem> learnerValues = (from x in sm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.SectionName,
                                                      Value = x.SectionID.ToString()
                                                  }).ToList();
            ViewBag.bolum = learnerValues;
            return View();
        }

        [HttpPost]
        public IActionResult PostAdd(PostAddClass p)
        {
            Post post = new Post();
            if (p.PostImage != null)
            {
                var extension = Path.GetExtension(p.PostImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.PostImage.CopyTo(stream);
                post.PostImage = "/Images/" +newImageName;
            }
            post.PostContent = p.PostContent;
            post.PostCreateDate = DateTime.Now;
            post.PostTitle = p.PostTitle;
            post.PostStatus = true;

            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();

            var learnerId = c.Learners.Where(x => x.LearnerMail == usermail).Select(x => x.LearnerID).FirstOrDefault();

            post.LearnerID = learnerId;
            post.SectionID = p.SectionID;
            pm.TAdd(post);
            return RedirectToAction("PostListByLearner", "Post");
        }
        public IActionResult DeletePost(int id)
        {
            var postValue = pm.TGetById(id);
            pm.TDelete(postValue);
            return RedirectToAction("PostListByLearner", "Post");
        }

        [HttpGet]
        public IActionResult EditPost(int id)
        {
            List<SelectListItem> sectionValues = (from x in sm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.SectionName,
                                                      Value = x.SectionID.ToString()
                                                  }).ToList();
            ViewBag.sv = sectionValues;
            var postValue = pm.TGetById(id);
            return View(postValue);
        }

        [HttpPost]
        public IActionResult EditPost(Post p)
        {
            if (p.ImageFile != null)
            {
                var extension = Path.GetExtension(p.ImageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageFile.CopyTo(stream);
                p.PostImage = "/Images/" + newImageName;
            }
            var username = User.Identity.Name;
            var learnerMail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var learnerID = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerID).FirstOrDefault();
            p.LearnerID = learnerID;
            p.PostCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.PostStatus = true;
            pm.TUpdate(p);
            return RedirectToAction("PostListByLearner","Post");
        }
    }
}
