using Microsoft.AspNetCore.Mvc;

namespace WebApplicationRestaurant.Areas.Manage.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
