using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class HeadComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {  
            return View(); 
        }

    }
}
