using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
