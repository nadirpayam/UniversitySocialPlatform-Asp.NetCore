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
    public class LearnerManager : ILearnerService
    {
        ILearnerDal _leaernerDal;

        public LearnerManager(ILearnerDal leaernerDal)
        {
            _leaernerDal = leaernerDal;
        }

        public List<Learner> GetLearnerById(int id)
        {
            return _leaernerDal.GetListAll(x => x.LearnerID == id);
        }

        public List<Learner> GetList()
        {
            return _leaernerDal.GetListAll();
        }

        
        public void TAdd(Learner t)
        {
            _leaernerDal.Insert(t);
        }

        public void TDelete(Learner t)
        {
            _leaernerDal.Delete(t);
        }

        public Learner TGetById(int id)
        {
            return _leaernerDal.GetById(id);
        }

        public void TUpdate(Learner t)
        {
            _leaernerDal.Update(t);
        }
    }
}
