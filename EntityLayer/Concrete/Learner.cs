﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Learner
    {
        [Key]
        public int LearnerID { get; set; }
        public string LearnerName { get; set; }
        public string LearnerSurname { get; set; }
        public string LearnerAbout { get; set; }
        public string LearnerImage { get; set; }
        public string LearnerMail { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string LearnerPassword { get; set; }
        public bool LearnerStatus { get; set; }
        public List<Post> Posts { get; set; }
        public int LearnerTypeID { get; set; }
        public LearnerType LearnerType { get; set; }
        public virtual ICollection<Messages> LearnerSender { get; set; }
        public virtual ICollection<Messages> LearnerReceiver { get; set; }
    }
}
