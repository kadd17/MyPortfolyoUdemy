using Microsoft.AspNetCore.Mvc;
using MyPortfolyoUdemy.DAL.Context;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class FeatureComponentPartial:ViewComponent
    {
        private readonly MyPortfolioContext _context;

        public FeatureComponentPartial(MyPortfolioContext context)
        {
            _context = context;
        }

        public  IViewComponentResult Invoke()
        {
            var values = _context.Features.ToList();
            return View(values);
        }
    }
}



