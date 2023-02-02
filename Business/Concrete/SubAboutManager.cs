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
    public class SubAboutManager: ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal) // EfSubAboutDal istiyorum!
        {
            _subAboutDal = subAboutDal;
        }

        public void TAdd(SubAbout tEntity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout tEntity)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDal.GetList();
        }

        public void TUpdate(SubAbout tEntity)
        {
            throw new NotImplementedException();
        }

        SubAbout IGenericService<SubAbout>.TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
