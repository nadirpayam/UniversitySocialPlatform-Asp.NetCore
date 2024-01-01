using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string LearnerPassword { get; set; }
        public bool LearnerStatus { get; set; }
        public List<Post> Posts { get; set; }
        public int LearnerTypeID { get; set; }
        public LearnerType LearnerType { get; set; }
    }
}
