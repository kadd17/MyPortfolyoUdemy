using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
            { return View(); }
    }
}
