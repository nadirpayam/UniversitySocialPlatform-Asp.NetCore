using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPostService
    {
        void PostAdd(Post s);
        void PostDelete(Post s);
        void PostUpdate(Post s);
        List<Post> GetList();
        Post GetById(int id);
        List<Post> GetListWithSectionLearner();
    }
}
