using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class LearnerType
    {
        [Key]
        public int LearnerTypeID { get; set; }
        public string LearnerTypeName { get; set; }
        public bool LearnerTypeStatus { get; set; }
        public List<Learner> Learners { get; set; }
    }
}
