using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace UniversitySocialPlatform.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class SectionController : Controller
    {
        SectionManager sm = new SectionManager(new EFSectionRepository());
        
        public IActionResult Index(int page=1)
        {
            var values = sm.GetList().ToPagedList(page,2);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSection(Section section)
        {
            SectionValidator validationRules = new SectionValidator();
            ValidationResult results = validationRules.Validate(section);

            
            if (results.IsValid)
            {
                section.SectionStatus = true;
                sm.TAdd(section);
                return RedirectToAction("Index", "Section");
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

        
        public IActionResult SectionDelete(int id)
        {
            var value = sm.TGetById(id);
            sm.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
