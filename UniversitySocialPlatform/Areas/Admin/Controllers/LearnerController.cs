using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversitySocialPlatform.Areas.Admin.Models;

namespace UniversitySocialPlatform.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class LearnerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LearnerList()
        {
            var jsonLearners = JsonConvert.SerializeObject(learners);
            return Json(jsonLearners);
        }

        public IActionResult GetLearnerByID(int learnerId)
        {
            var findLearner = learners.FirstOrDefault(x => x.Id == learnerId);
            var jsonLearners = JsonConvert.SerializeObject(findLearner);
            return Json(jsonLearners);
        }

        [HttpPost]
        public IActionResult AddLearner(LearnerClass l)
        {
            learners.Add(l);
            var jsonLearners = JsonConvert.SerializeObject(l);
            return Json(jsonLearners);
        }

        public IActionResult DeleteLearner(int id)
        {
            var learner = learners.FirstOrDefault(x => x.Id == id);
            learners.Remove(learner);
            return Json(learner);
        }

        public IActionResult UpdateLearner(LearnerClass l)
        {
            var learner = learners.FirstOrDefault(x => x.Id == l.Id);
            learner.Name = l.Name;
            var jsonWriter = JsonConvert.SerializeObject(l);
            return Json(jsonWriter);
        }

        public static List<LearnerClass> learners = new List<LearnerClass>
        {
            new LearnerClass
            {
                Id=1,
                Name="Nadir"
            },
            new LearnerClass
            {
                Id=2,
                Name="Yusuf"
            },
            new LearnerClass
            {
                Id=1,
                Name="Rojhat"
            }
        };
    }
}
