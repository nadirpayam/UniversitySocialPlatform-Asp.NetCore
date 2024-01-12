using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.ViewComponents.Learner
{
    public class LearnerAboutOnDashborad: ViewComponent
    {
        LearnerManager lm = new LearnerManager(new EFLearnerRepository());
        Context c = new Context();


        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            ViewBag.abo = username;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var learnerID = c.Learners.Where(x => x.LearnerMail == usermail).Select(x => x.LearnerID).FirstOrDefault();
            var values = lm.GetLearnerById(learnerID);
            return View(values);
        }
    }
}
