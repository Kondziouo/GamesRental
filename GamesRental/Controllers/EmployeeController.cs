using GamesRental.Data;
using GamesRental.Interfaces;
using GamesRental.Models;
using Microsoft.AspNetCore.Mvc;
using GamesRental.Repository;

namespace GamesRental.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Employee> employees = await _employeeRepository.GetAll();
            return View(employees);

        }
        public async Task<IActionResult> Detail(int id)
        {
            Employee employee = await _employeeRepository.GetByIdAsync(id);
            return View(employee);
        }
    }
}
