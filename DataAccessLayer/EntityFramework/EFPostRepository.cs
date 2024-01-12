using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFPostRepository : GenericRepository<Post>, IPostDal
    {
        public List<Post> GetListWithSectionByLearner(int id)
        {
            using (var c = new Context())
            {
                return c.Posts.Include(x => x.Section).Where(
                    x => x.LearnerID == id).ToList();
            }
        }

        public List<Post> GetListWithSectionLearner()
        {
            using(var c = new Context())
            {
                return c.Posts.Include(x => x.Section)
                 .Include(x => x.Learner)
                 .ThenInclude(y => y.LearnerType)
                 .ToList();
            }
        }

        public List<Post> GetListWithSectionLearnerSectionID(int id)
        {
            using (var c = new Context())
            {
                return c.Posts.Include(x => x.Section)
                 .Include(x => x.Learner)
                 .ThenInclude(y => y.LearnerType)
                 .Where(p => p.SectionID == id)
                 .ToList();
            }
        }
    }
}
