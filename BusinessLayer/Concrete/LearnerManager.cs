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

        public void LeanerAdd(Learner s)
        {
            _leaernerDal.Insert(s);
        }
    }
}
