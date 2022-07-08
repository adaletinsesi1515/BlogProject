using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UnvanManager : IUnvanService
    {
        EfUnvanDal _unvanDal;

        public UnvanManager(EfUnvanDal unvanDal)
        {
            _unvanDal = unvanDal;
        }

        public void TAdd(Unvan t)
        {
            _unvanDal.Insert(t);
        }

        public void TDelete(Unvan t)
        {
            _unvanDal.Delete(t);
        }

        public Unvan TGetbyID(int id)
        {
            return _unvanDal.GetById(id);
        }

        public List<Unvan> TGetList()
        {
            return _unvanDal.GetList();
        }

        public void TUpdate(Unvan t)
        {
            _unvanDal.Update(t);
        }
    }
}
