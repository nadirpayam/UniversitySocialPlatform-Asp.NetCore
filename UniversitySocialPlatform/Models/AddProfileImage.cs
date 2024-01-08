using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversitySocialPlatform.Models
{
    public class AddProfileImage
    {
        public int LearnerID { get; set; }
        public string LearnerName { get; set; }
        public string LearnerSurname { get; set; }
        public string LearnerAbout { get; set; }
        public IFormFile LearnerImage { get; set; }
        public string LearnerMail { get; set; }
        public string LearnerPassword { get; set; }
    }
}
