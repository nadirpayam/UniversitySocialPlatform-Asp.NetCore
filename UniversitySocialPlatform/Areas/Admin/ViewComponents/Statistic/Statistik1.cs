using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UniversitySocialPlatform.Areas.Admin.ViewComponents.Statistic
{
    public class Statistik1: ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.PostCount = c.Posts.Count();
            ViewBag.ContactCount = c.Contacts.Count();
            ViewBag.CommentCount = c.Comments.Count();

            /*string api = "c231addc9c1a239b32cf3a9c72362f87";
            string connection ="https://api.openweathermap.org/data/2.5/weather?lat=41.0082&lon=28.9784&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.Hava = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;*/
            return View();
        }
    }
}
