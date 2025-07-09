using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { return View(); }
    }
}
