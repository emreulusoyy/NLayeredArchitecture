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
    public class HakkindaManager:IHakkindaService
    {
        IHakkındaDal _hakkindaDal;

        public HakkindaManager(IHakkındaDal hakkindaDal)
        {
            _hakkindaDal = hakkindaDal;
        }

        public void TAdd(Hakkında t)
        {
            _hakkindaDal.Insert(t); 
        }

        public void TDelete(Hakkında t)
        {
            _hakkindaDal.Delete(t);
        }

        public Hakkında TGetByID(int id)
        {
            return _hakkindaDal.GetByID(id);    
        }

        public List<Hakkında> TGetList()
        {
           return _hakkindaDal.GetList();
        }

        public void TUpdate(Hakkında t)
        {
            _hakkindaDal.Update(t); 
        }
    }
}
