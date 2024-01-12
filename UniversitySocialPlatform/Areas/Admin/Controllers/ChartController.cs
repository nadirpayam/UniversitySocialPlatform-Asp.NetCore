using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversitySocialPlatform.Areas.Admin.Models;

namespace UniversitySocialPlatform.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SectionChart()
        {
            List<SectionClass> list = new List<SectionClass>();
            list.Add(new SectionClass
            {
                categoryname = "Teknoloji",
                categorycount = 10
            });
            list.Add(new SectionClass
            {
                categoryname = "Yazılım",
                categorycount = 14
            });
            list.Add(new SectionClass
            {
                categoryname = "Spor",
                categorycount = 5
            });
            list.Add(new SectionClass
            {
                categoryname = "Sinema",
                categorycount = 2
            });

            return Json(new { jsonlist = list });
        }
    }
}
