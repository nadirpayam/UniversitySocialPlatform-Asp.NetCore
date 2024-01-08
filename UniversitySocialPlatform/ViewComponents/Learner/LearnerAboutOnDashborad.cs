using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
            var learnerMail = User.Identity.Name;
            var learnerID = c.Learners.Where(x => x.LearnerMail == learnerMail).Select(x => x.LearnerID).FirstOrDefault();
            var values = lm.GetLearnerById(learnerID);
            return View(values);
        }
    }
}
