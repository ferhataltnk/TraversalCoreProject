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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About tEntity)
        {
           _aboutDal.Insert(tEntity);
        }

        public void TDelete(About tEntity)
        {
            _aboutDal.Delete(tEntity);
        }

        public List<About> TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TUpdate(About tEntity)
        {
           _aboutDal.Update(tEntity);
        }

        About IGenericService<About>.TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
