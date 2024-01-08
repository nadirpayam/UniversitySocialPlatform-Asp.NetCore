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
    public class LearnerTypeManager : ILearnerTypeService
    {
        ILearnerTypeDal _learnerTypeDal;

        public LearnerTypeManager(ILearnerTypeDal learnerTypeDal)
        {
            _learnerTypeDal = learnerTypeDal;
        }

        public LearnerType TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<LearnerType> GetList()
        {
            return _learnerTypeDal.GetListAll();
        }

        public void TAdd(LearnerType t)
        {
            _learnerTypeDal.Insert(t);
        }

        public void TDelete(LearnerType t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(LearnerType t)
        {
            throw new NotImplementedException();
        }
    }
}
