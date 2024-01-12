
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.ViewComponents.Post
{
    public class LearnerLastPost: ViewComponent
    {
        PostManager pm = new PostManager(new EFPostRepository());
        Context c = new Context();

        public IViewComponentResult Invoke(int id)
        {
            var learnerId = c.Posts.Where(x => x.PostID == id).Select(x => x.LearnerID).FirstOrDefault();
            var values = pm.GetPostListByLearner(learnerId);
            return View(values);
        }
    }
}
