using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Controllers
{
    public class SectionController : Controller
    {
        SectionManager sm = new SectionManager(new EFSectionRepository());
        public IActionResult Index()
        {
            var values = sm.GetList();
            return View(values);
        }

       
    }
}
