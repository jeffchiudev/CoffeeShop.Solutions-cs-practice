using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}