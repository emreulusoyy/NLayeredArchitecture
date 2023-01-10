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
    public class SliderManager:ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(Slider t)
        {
            _sliderDal.Insert(t);
        }

        public void TDelete(Slider t)
        {
           _sliderDal.Delete(t);
        }

        public Slider TGetByID(int id)
        {
            return _sliderDal.GetByID(id);
        }

        public List<Slider> TGetList()
        {
            return _sliderDal.GetList();
        }

        public void TUpdate(Slider t)
        {
            _sliderDal.Update(t);
        }
    }
}
