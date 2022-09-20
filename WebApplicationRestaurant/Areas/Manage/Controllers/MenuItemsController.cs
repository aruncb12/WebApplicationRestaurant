using Microsoft.AspNetCore.Mvc;

namespace WebApplicationRestaurant.Areas.Manage.Controllers
{
    public class MenuItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
