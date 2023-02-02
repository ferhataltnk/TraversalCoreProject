using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial tEntity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial tEntity)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TUpdate(Testimonial tEntity)
        {
            throw new NotImplementedException();
        }

        Testimonial IGenericService<Testimonial>.TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
