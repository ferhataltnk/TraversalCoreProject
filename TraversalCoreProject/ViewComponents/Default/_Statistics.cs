
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            using var c = new TraversalContext();
            ViewBag.v1 = c.Destinations.Count();  //Tablo sütununa ulaştık direkt
            ViewBag.v2 = c.Guides.Count(); 
            ViewBag.v3 = "285"; 

            return View();
        }
    }
}
