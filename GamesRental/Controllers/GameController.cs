using GamesRental.Data;
using GamesRental.Interfaces;
using GamesRental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GamesRental.Repository;
using GamesRental.ViewModels;

namespace GamesRental.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly IPhotoService _photoService;

        public GameController(IGameRepository gameRepository, IPhotoService photoService)
        {
            _gameRepository = gameRepository;
            _photoService = photoService;
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
        public async Task<IActionResult> Create(CreateGameViewModel gameVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(gameVM.Image);

                var game = new Game
                {
                    Title = gameVM.Title,
                    Description = gameVM.Description,
                    Image = result.Url.ToString(),
                    Price = gameVM.Price
                };
                _gameRepository.Add(game);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Photo upload failed");
            }

            return View(gameVM);

        }

    }
}
