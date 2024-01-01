using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Section
    {
        [Key]
        public int SectionID { get; set; }
        public string SectionName { get; set; }
        public string SectionDescription { get; set; }
        public bool SectionStatus { get; set; }
        public List<Post> Posts { get; set; }
    }
}
