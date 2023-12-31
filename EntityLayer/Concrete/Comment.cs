﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentAnonymousName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentCreateDate { get; set; }
        public int PostScore { get; set; }
        public bool CommentStatus { get; set; }
        public int PostID { get; set; }
        public Post Post { get; set; }
    }
}
