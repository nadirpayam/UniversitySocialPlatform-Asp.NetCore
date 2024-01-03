using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.ViewComponents.Section
{
    public class SectionList: ViewComponent
    {
        SectionManager sm = new SectionManager(new EFSectionRepository());

        public IViewComponentResult Invoke()
        {
            var values = sm.GetList();
            return View(values);
        }
    }
}
