using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SectionManager : ISectionService
    {
        ISectionDal _sectionDal;

        public SectionManager(ISectionDal sectionDal)
        {
            _sectionDal = sectionDal;
        }

        public Section TGetById(int id)
        {
            return _sectionDal.GetById(id);
        }
        public List<Section> GetList()
        {
            return _sectionDal.GetListAll();
        }
        public void TAdd(Section t)
        {
            _sectionDal.Insert(t);
        }
        public void TDelete(Section t)
        {
            _sectionDal.Delete(t);
        }

        public void TUpdate(Section t)
        {
            _sectionDal.Update(t);
        }
    }
}
