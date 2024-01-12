
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageRepository());
        LearnerManager lm = new LearnerManager(new EFLearnerRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var learnerId = c.Learners.Where(x => x.LearnerMail == usermail).Select(x => x.LearnerID).FirstOrDefault();
            var values = mm.GetListWithMessagesLearner(learnerId);
            return View(values);
        }

       
        public IActionResult MessageDetails(int id)
        {
            var value = mm.TGetById(id);
            return View(value);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            List<SelectListItem> learnerValuesd = (from x in lm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.LearnerName + " " +x.LearnerSurname,
                                                       Value = x.LearnerID.ToString()
                                                   }).ToList();
            ViewBag.send = learnerValuesd;
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Messages messages)
        {
            var username = User.Identity.Name;
            var learnerMail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var learnerID = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerID).FirstOrDefault();
            messages.SenderID = learnerID;
            messages.MessageStatus = true;
            messages.MessageDate = DateTime.Now;
            mm.TAdd(messages);
            return RedirectToAction("Index","Dashboard");
        }
    }
}
