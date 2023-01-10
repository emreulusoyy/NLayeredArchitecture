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
    public class AltSliderManager : IAltSliderService
    {
        IAltSliderDal _altSlider;

        public AltSliderManager(IAltSliderDal altSlider)
        {
            _altSlider = altSlider;
        }

        public void TAdd(AltSlider t)
        {
            _altSlider.Insert(t);   
        }

        public void TDelete(AltSlider t)
        {
            _altSlider.Delete(t);
        }

        public AltSlider TGetByID(int id)
        {
            return _altSlider.GetByID(id);  
        }

        public List<AltSlider> TGetList()
        {
            return _altSlider.GetList();
        }

        public void TUpdate(AltSlider t)
        {
            _altSlider.Update(t);   
        }
    }
}
