using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void CommentAdd(Comment c)
        {
            _commentDal.Insert(c);
        }

        public void CommentDelete(Comment s)
        {
            throw new NotImplementedException();
        }

        public void CommentUpdate(Comment s)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
            return _commentDal.GetListAll(x=>x.PostID==id);
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
