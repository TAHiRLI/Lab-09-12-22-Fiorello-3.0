using Microsoft.AspNetCore.Mvc;

namespace Fiorello_Lab.Areas.Manage.Controllers
{
    [Area("manage")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
