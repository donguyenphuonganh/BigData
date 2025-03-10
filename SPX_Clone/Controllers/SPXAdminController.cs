using Microsoft.AspNetCore.Mvc;

namespace SPX_Clone.Controllers
{
    public class SPXAdminController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("SPXAdmin/Index is called");
            return View();
        }
        
    }
}
