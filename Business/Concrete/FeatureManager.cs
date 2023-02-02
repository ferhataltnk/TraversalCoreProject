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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature tEntity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature tEntity)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature tEntity)
        {
            throw new NotImplementedException();
        }

        Feature IGenericService<Feature>.TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
