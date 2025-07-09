using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class PortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
