using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
