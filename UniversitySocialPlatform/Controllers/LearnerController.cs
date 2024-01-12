using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UniversitySocialPlatform.Models;

namespace UniversitySocialPlatform.Controllers
{
    public class LearnerController : Controller
    {
        LearnerManager lm = new LearnerManager(new EFLearnerRepository());
        LearnerTypeManager lt = new LearnerTypeManager(new EFLearnerTypeRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var learnerMail = User.Identity.Name;
            ViewBag.learnerMail = learnerMail;
            Context c = new Context();
            var learnerName = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerName).FirstOrDefault();
            ViewBag.learnerName = learnerName;
            return View();
        }

        public IActionResult LearnerProfile()
        {
            return View();
        }

        public IActionResult LearnerMail()
        {
            return View();
        }

       
        public IActionResult Test()
        {
            return View();
        }

        
        public PartialViewResult LearnerNavbar()
        {
            return PartialView();
        }

    
        public PartialViewResult LearnerFooterPartial()
        {
            return PartialView();
        }

        
        [HttpGet]
        public IActionResult LearnerEditProfile()
        {
            List<SelectListItem> learnerValuesd = (from x in lt.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.LearnerTypeName,
                                                      Value = x.LearnerTypeID.ToString()
                                                  }).ToList();
            ViewBag.type = learnerValuesd;
            var username = User.Identity.Name;
            var learnerMail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var learnerID = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerID).FirstOrDefault();
            var learnerValues = lm.TGetById(learnerID);
            return View(learnerValues);
        }

      
        [HttpPost]
        public IActionResult LearnerEditProfile(Learner learner)
        {
            if (learner.ImageFile != null)
            {
                var extension = Path.GetExtension(learner.ImageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                learner.ImageFile.CopyTo(stream);
                learner.LearnerImage = "/Images/" + newImageName;
            }
            learner.LearnerStatus = true;
            
            lm.TUpdate(learner);
            return RedirectToAction("PostListByLearner", "Post");
        }

      
        [HttpGet]
        public IActionResult LearnerAdd()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult LearnerAdd(AddProfileImage learner)
        {
            Learner l = new Learner();
            if(learner.LearnerImage != null)
            {
                var extension = Path.GetExtension(learner.LearnerImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/LearnerImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                learner.LearnerImage.CopyTo(stream);
                l.LearnerImage = newImageName;
            }
            l.LearnerStatus = true;
            l.LearnerName = learner.LearnerName;
            l.LearnerSurname = learner.LearnerSurname;
            l.LearnerPassword = learner.LearnerPassword;
            l.LearnerMail = learner.LearnerMail;
            l.LearnerAbout = learner.LearnerAbout;
            l.LearnerTypeID = learner.LearnerID;
            lm.TAdd(l);
            return View();
        }
    }
    
}
