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
    public class BirimManager : IBirimService
    {
        EfBirimDal _birimDal;

        public BirimManager(EfBirimDal birimDal)
        {
            _birimDal = birimDal;
        }

        public void TAdd(Birim t)
        {
            _birimDal.Insert(t);
        }

        public void TDelete(Birim t)
        {
            _birimDal.Delete(t);
        }

        public Birim TGetbyID(int id)
        {
            return _birimDal.GetById(id);
        }

        public List<Birim> TGetList()
        {
            return _birimDal.GetList();
        }

        public void TUpdate(Birim t)
        {
            _birimDal.Update(t);
        }
    }
}
