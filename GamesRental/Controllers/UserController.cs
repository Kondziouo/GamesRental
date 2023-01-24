using GamesRental.Data;
using Microsoft.AspNetCore.Mvc;
using GamesRental.Models;

namespace GamesRental.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Customer> customers = _context.Customers.ToList();
            return View(customers);
        }

        public IActionResult Detail(int id)
        {
            Customer customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            return View(customer);
        }
    }
}
