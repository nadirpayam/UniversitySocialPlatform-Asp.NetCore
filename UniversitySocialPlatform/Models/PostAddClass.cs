using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Models
{
    public class PostAddClass
    {
        public int PostID { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public string PostThumbnailImage { get; set; }
        public IFormFile PostImage { get; set; }
        public bool PostStatus { get; set; }
        public int SectionID { get; set; }
    }
}
