using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HaberBulteniManager : IHaberBulteniDal
    {
        IHaberBulteniDal _haberdal;

        public HaberBulteniManager(IHaberBulteniDal haberdal)
        {
            _haberdal = haberdal;
        }

        public void Delete(HaberBulteni t)
        {
            _haberdal.Delete(t);    
        }

        public HaberBulteni GetByID(int id)
        {
            return _haberdal.GetByID(id);   
        }

        public List<HaberBulteni> GetList()
        {
           return _haberdal.GetList();
        }

        public void Insert(HaberBulteni t)
        {
           _haberdal.Insert(t); 
        }

        public void Update(HaberBulteni t)
        {
           _haberdal.Update(t);
        }
    }
}
