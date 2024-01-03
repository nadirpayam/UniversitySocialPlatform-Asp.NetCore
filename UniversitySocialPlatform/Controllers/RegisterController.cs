using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Controllers
{
    public class RegisterController : Controller
    {
        LearnerManager lm = new LearnerManager(new EFLearnerRepository());
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Learner learner)
        {
            LearnerValidator validationRules = new LearnerValidator();
            ValidationResult results = validationRules.Validate(learner);
            if (results.IsValid) {
                learner.LearnerAbout = "deneme";
                learner.LearnerStatus = true;
                learner.LearnerTypeID = 1;
                lm.LeanerAdd(learner);
                return RedirectToAction("Index", "Post");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
