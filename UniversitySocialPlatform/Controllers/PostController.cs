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

namespace UniversitySocialPlatform.Controllers
{
   
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

        public IActionResult PostReadAll(int id)
        {
            ViewBag.PostId = id;
            var values = pm.GetPostById(id);
            return View(values);
        }

        public IActionResult PostListByLearner()
        {
            var learnerMail = User.Identity.Name;
            var learnerID = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerID).FirstOrDefault();
            var values = pm.GetListWithSectionByLearnerPm(learnerID);
            return View(values);
        }

        [HttpGet]
        public IActionResult PostAdd()
        {
            List<SelectListItem> sectionValues = (from x in sm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.SectionName,
                                                      Value = x.SectionID.ToString()
                                                  }).ToList();
            ViewBag.sv = sectionValues;
            return View();
        }

        [HttpPost]
        public IActionResult PostAdd(Post p)
        {
            PostValidator validationRules = new PostValidator();
            ValidationResult results = validationRules.Validate(p);

            var learnerMail = User.Identity.Name;
            var learnerID = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerID).FirstOrDefault();

            if (results.IsValid)
            {
                p.PostStatus = true;
                p.LearnerID = learnerID;
                p.PostCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                pm.TAdd(p);
                return RedirectToAction("PostListByLearner", "Post");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
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
            var learnerMail = User.Identity.Name;
            var learnerID = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerID).FirstOrDefault();
            p.LearnerID = learnerID;
            p.PostCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.PostStatus = true;
            pm.TUpdate(p);
            return RedirectToAction("PostListByLearner","Post");
        }
    }
}
