using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment c);
        void CommentDelete(Comment s);
        void CommentUpdate(Comment s);
        List<Comment> GetList();
        List<Comment> GetList(int id);
        Comment GetById(int id);
    }
}
