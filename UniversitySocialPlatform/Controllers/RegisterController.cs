using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        LearnerManager lm = new LearnerManager(new EFLearnerRepository());
        LearnerTypeManager lt = new LearnerTypeManager(new EFLearnerTypeRepository());
        [HttpGet]
        public IActionResult Index()
        {
            List<SelectListItem> learnerValues = (from x in lt.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.LearnerTypeName,
                                                      Value = x.LearnerTypeID.ToString()
                                                  }).ToList();
            ViewBag.sv = learnerValues;
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
                lm.TAdd(learner);
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
