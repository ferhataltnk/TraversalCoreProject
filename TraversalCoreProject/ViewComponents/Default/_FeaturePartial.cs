using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        FeatureManager _featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            //var values = _featureManager.TGetList();
            //ViewBag.image1=_featureManager.get
            return View();
        }
    }
}
