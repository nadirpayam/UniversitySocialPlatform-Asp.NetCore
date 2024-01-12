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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Messages> GetInboxListByLearner(int id)
        {
            return _messageDal.GetListWithMessagesLearner(id);
        }

        public List<Messages> GetList()
        {
            return _messageDal.GetListAll();
        }

        public List<Messages> GetListWithMessagesLearner(int id)
        {
            return _messageDal.GetListWithMessagesLearner(id);
        }

        public void TAdd(Messages t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Messages t)
        {
            throw new NotImplementedException();
        }

        public Messages TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public void TUpdate(Messages t)
        {
            throw new NotImplementedException();
        }
    }
}
