using GamesRental.Data;
using GamesRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamesRental.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();
            return View(employees);

        }
        public IActionResult Detail(int id)
        {
            Employee employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            return View(employee);
        }
    }
}
