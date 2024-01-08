using BusinessLayer.Concrete;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UniversitySocialPlatform.Areas.Admin.Models;

namespace UniversitySocialPlatform.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class PostController : Controller
    {
        PostManager pm = new PostManager(new EFPostRepository());
        public IActionResult ExportStaticExcelPostList()
        {
            using(var workbook=new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Gönderi Listesi");
                worksheet.Cell(1, 1).Value = "Gönderi ID";
                worksheet.Cell(1, 2).Value = "Gönderi Adı";

                int postRowCount = 2;

                foreach(var item in GetPostList())
                {
                    worksheet.Cell(postRowCount, 1).Value = item.ID;
                    worksheet.Cell(postRowCount, 2).Value = item.PostName;
                    postRowCount++;
                }
                using(var stream=new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Gönderiler.xlsx");
                }
            }
        }

        public List<PostModel> GetPostList()
        {
            List<PostModel> post = new List<PostModel>
            {
                new PostModel{ID=1,PostName="Uzay" } 
            };
            return post;
        }
      
        public IActionResult PostListExcel()
        {
            return View();
        }

        public IActionResult ExportDinamicExcelPostList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Gönderi Listesi");
                worksheet.Cell(1, 1).Value = "Gönderi ID";
                worksheet.Cell(1, 2).Value = "Gönderi Başlığı";
                worksheet.Cell(1, 3).Value = "Gönderi Tarihi";

                int postRowCount = 2;

                foreach (var item in GetPostListModel())
                {
                    worksheet.Cell(postRowCount, 1).Value = item.ID;
                    worksheet.Cell(postRowCount, 2).Value = item.Title;
                    worksheet.Cell(postRowCount, 3).Value = item.CreateDate;
                    postRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Gönderiler.xlsx");
                }
            }
        }

        public List<PostListModel> GetPostListModel()
        {
            List<PostListModel> pmodel = new List<PostListModel>();

            using(var c = new Context())
            {
                pmodel = c.Posts.Select(x => new PostListModel
                {
                    ID = x.PostID,
                    Title = x.PostTitle,
                    CreateDate=x.PostCreateDate
                }).ToList();
                return pmodel;
            }
        }

        public IActionResult PostListModelExcel()
        {
            return View();
        }
   }
}
