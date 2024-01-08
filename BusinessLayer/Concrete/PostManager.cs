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
    public class PostManager : IPostService
    {
        IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public Post TGetById(int id)
        {
            return _postDal.GetById(id);
        }

        public List<Post> GetPostById(int id)
        {
            return _postDal.GetListAll(x=>x.PostID==id);
        }

        public List<Post> GetLast3Post()
        {
            return _postDal.GetListAll().Take(3).ToList();
        }

        public List<Post> GetListWithSectionLearner()
        {
            return _postDal.GetListWithSectionLearner();
        }

        public List<Post> GetList()
        {
            return _postDal.GetListAll();
        }

        public List<Post> GetPostListByLearner(int id)
        {
            return _postDal.GetListAll(x => x.LearnerID == id);
        }

        public List<Post> GetListWithSectionByLearnerPm(int id)
        {
            return _postDal.GetListWithSectionByLearner(id);
        }

        public void TAdd(Post t)
        {
            _postDal.Insert(t);
        }

        public void TDelete(Post t)
        {
            _postDal.Delete(t);
        }

        public void TUpdate(Post t)
        {
            _postDal.Update(t);
        }
    }
}
