using GamesRental.Data;
using GamesRental.Interfaces;
using GamesRental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GamesRental.Repository;

namespace GamesRental.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GameController (IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }


    
        public async Task<IActionResult> Index()
        {
            IEnumerable<Game> games = await _gameRepository.GetAll();
            return View(games);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Game game = await _gameRepository.GetByIdAsync(id);
            return View(game);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create (Game game)
        {
            if (!ModelState.IsValid)
            {
                return View(game);
            }

            _gameRepository.Add(game);
            return RedirectToAction("Index");
        }
        
    }
}
