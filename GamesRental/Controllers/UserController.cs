using GamesRental.Data;
using Microsoft.AspNetCore.Mvc;
using GamesRental.Models;
using GamesRental.Interfaces;
using GamesRental.Repository;
using Microsoft.AspNetCore.Authorization;

namespace GamesRental.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Customer> customers = await _userRepository.GetAll();
            return View(customers);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Customer customer = await _userRepository.GetByIdAsync(id);
            return View(customer);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var userDetails = await _userRepository.GetByIdAsync(id);
            if (userDetails == null) return View("Error");
            return View(userDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            var userDetails = await _userRepository.GetByIdAsync(id);
            if (userDetails == null) return View("Error");

            _userRepository.Delete(userDetails);
            return RedirectToAction("Index");
        }
    }
}
