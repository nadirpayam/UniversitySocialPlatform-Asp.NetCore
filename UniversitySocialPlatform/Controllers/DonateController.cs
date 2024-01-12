using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Controllers
{
    [AllowAnonymous]
    public class DonateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
