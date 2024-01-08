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
    public class EFMessageRepository : GenericRepository<Messages>, IMessageDal
    {
        public List<Messages> GetListWithMessagesLearner(int id)
        {
            using (var c = new Context())
            {
                return c.AllMessages.Include(x => x.SenderLearner).ThenInclude(y => y.LearnerType).Where(
                    x => x.SenderID == id || x.ReceiverID==id).ToList();
            }
        }

    }
}
