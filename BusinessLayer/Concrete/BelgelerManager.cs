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
    public class BelgelerManager:IBelgelerService
    {
        IBelgelerDal _belgelerDal;

        public BelgelerManager(IBelgelerDal belgelerDal)
        {
            _belgelerDal = belgelerDal;
        }

        public void TAdd(Belgeler t)
        {
            _belgelerDal.Insert(t);
        }

        public void TDelete(Belgeler t)
        {
           _belgelerDal.Delete(t);
        }

        public Belgeler TGetByID(int id)
        {
            return _belgelerDal.GetByID(id);
        }

        public List<Belgeler> TGetList()
        {
           return _belgelerDal.GetList();
        }

        public void TUpdate(Belgeler t)
        {
            _belgelerDal.Update(t);
        }
    }
}
