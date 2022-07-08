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
    public class PersonelManager : IPersonelService
    {
        EfPersonelDal _personelDal;

        public PersonelManager(EfPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public void TAdd(Personel t)
        {
            _personelDal.Insert(t);
        }

        public void TDelete(Personel t)
        {
            _personelDal.Delete(t);
        }

        public Personel TGetbyID(int id)
        {
            return _personelDal.GetById(id);
        }

        public List<Personel> TGetList()
        {
            return _personelDal.GetList();
        }

        public void TUpdate(Personel t)
        {
            _personelDal.Update(t);
        }
    }
}
