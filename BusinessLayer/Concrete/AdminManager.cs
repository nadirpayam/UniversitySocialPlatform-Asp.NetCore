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
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public List<Adminim> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Adminim t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Adminim t)
        {
            throw new NotImplementedException();
        }

        public Adminim TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Adminim t)
        {
            throw new NotImplementedException();
        }
    }
}
