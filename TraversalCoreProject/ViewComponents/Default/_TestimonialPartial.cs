using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _TestimonialPartial: ViewComponent
    {
        TestimonialManager _testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = _testimonialManager.TGetList();
            return View(values);         
             
        }
    }
}
