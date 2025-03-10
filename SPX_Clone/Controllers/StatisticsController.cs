using Microsoft.AspNetCore.Mvc;

namespace SPX_Clone.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
