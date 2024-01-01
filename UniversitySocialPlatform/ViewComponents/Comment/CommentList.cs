using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.ViewComponents.Comment
{
    public class CommentList: ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
