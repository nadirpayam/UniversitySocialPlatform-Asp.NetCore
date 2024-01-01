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

        public Section GetById(int id)
        {
            return _sectionDal.GetById(id);
        }

        public List<Section> GetList()
        {
            return _sectionDal.GetListAll();
        }

        public void SectionAdd(Section s)
        {
            _sectionDal.Insert(s);
        }

        public void SectionDelete(Section s)
        {
            _sectionDal.Delete(s);
        }

        public void SectionUpdate(Section s)
        {
            _sectionDal.Update(s);
        }
    }
}
