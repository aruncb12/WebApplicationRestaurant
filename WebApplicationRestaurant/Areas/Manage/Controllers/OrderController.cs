using Microsoft.AspNetCore.Mvc;

namespace WebApplicationRestaurant.Areas.Manage.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
