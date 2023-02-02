using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _SubAboutPartial:ViewComponent
    {
        SubAboutManager _subAboutManager = new SubAboutManager(new EfSubAboutDal());
        
       public IViewComponentResult Invoke()
        {
            var values = _subAboutManager.TGetList();
            return View(values);
        }
            
    }
}
