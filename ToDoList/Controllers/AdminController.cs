using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
