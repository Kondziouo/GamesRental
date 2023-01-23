using Microsoft.AspNetCore.Mvc;

namespace GamesRental.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
