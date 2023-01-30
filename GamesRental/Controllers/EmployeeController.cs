using GamesRental.Data;
using GamesRental.Interfaces;
using GamesRental.Models;
using Microsoft.AspNetCore.Mvc;
using GamesRental.Repository;
using GamesRental.ViewModels;
using GamesRental.Services;
using Microsoft.AspNetCore.Authorization;

namespace GamesRental.Controllers
{
    [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee
                {
                    FirstName = employeeVM.FirstName,
                    LastName = employeeVM.LastName,
                    DateOfBirth = employeeVM.DateOfBirth,
                    ContactNumber = employeeVM.ContactNumber,
                    Email = employeeVM.Email
                };
                _employeeRepository.Add(employee);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Edit failed");
            }
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null) return View("Error");
            var employeeVM = new EditEmployeeViewModel
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                DateOfBirth= employee.DateOfBirth,
                ContactNumber = employee.ContactNumber,
                Email = employee.Email
            };
            return View(employeeVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditEmployeeViewModel employeeVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit game");
                return View("Edit", employeeVM);
            }

            var userEmployee = await _employeeRepository.GetByIdAsyncNoTracking(id);

            if (userEmployee != null)
            {
                var employee = new Employee
                {
                    FirstName = employeeVM.FirstName,
                    LastName = employeeVM.LastName,
                    DateOfBirth = employeeVM.DateOfBirth,
                    ContactNumber = employeeVM.ContactNumber,
                    Email = employeeVM.Email
                };

                _employeeRepository.Update(employee);

                return RedirectToAction("Index");
            }
            else
            {
                return View(employeeVM);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var employeeDetails = await _employeeRepository.GetByIdAsync(id);
            if (employeeDetails == null) return View("Error");
            return View(employeeDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employeeDetails = await _employeeRepository.GetByIdAsync(id);
            if (employeeDetails == null) return View("Error");

            _employeeRepository.Delete(employeeDetails);
            return RedirectToAction("Index");
        }



    }
}
