using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISectionService
    {
        void SectionAdd(Section s);
        void SectionDelete(Section s);
        void SectionUpdate(Section s);
        List<Section> GetList();
        Section GetById(int id);
    }
}
