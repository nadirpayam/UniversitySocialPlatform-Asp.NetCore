using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PostRating
    {
        [Key]
        public int PostRatingID { get; set; }
        public int PostID { get; set; }
        public int PostTotalScore { get; set; }
        public int PostRatingCount { get; set; }
    }
}
