using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class AboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
            {
            return View();
            }
    }
}
