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

        public Post GetById(int id)
        {
            return _postDal.GetById(id);
        }

        public List<Post> GetPostById(int id)
        {
            return _postDal.GetListAll(x=>x.PostID==id);
        }

        public List<Post> GetListAll()
        {
            return _postDal.GetListAll();
        }

        public List<Post> GetLast3Post()
        {
            return _postDal.GetListAll().Take(3).ToList();
        }

        public List<Post> GetListWithSectionLearner()
        {
            return _postDal.GetListWithSectionLearner();
        }

        public void PostAdd(Post s)
        {
            throw new NotImplementedException();
        }

        public void PostDelete(Post s)
        {
            throw new NotImplementedException();
        }

        public void PostUpdate(Post s)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Post> GetPostListByLearner(int id)
        {
            return _postDal.GetListAll(x => x.LearnerID == id);
        }
    }
}
