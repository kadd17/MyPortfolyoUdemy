using Microsoft.AspNetCore.Mvc;
using MyPortfolyoUdemy.DAL.Context;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
              return View();
        }
    }
}
