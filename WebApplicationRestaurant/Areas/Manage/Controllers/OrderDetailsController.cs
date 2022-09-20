using Microsoft.AspNetCore.Mvc;

namespace WebApplicationRestaurant.Areas.Manage.Controllers
{
    public class OrderDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
