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

        public async Task<IActionResult> Edit(int id)
        {
            var game = await _gameRepository.GetByIdAsync(id);
            if (game == null) return View("Error");
            var gameVM = new EditGameViewModel
            {
                Title = game.Title,
                URL = game.Image,
                Description = game.Description,
                Price = game.Price
            };
            return View(gameVM);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditGameViewModel gameVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit game");
                return View("Edit", gameVM);
            }

            var userGame = await _gameRepository.GetByIdAsyncNoTracking(id);

            if (userGame != null)
            {
                try
                {
                    await _photoService.DeletePhotoAsync(userGame.Image);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Could not delete photo");
                    return View(gameVM);
                }

                var photoResult = await _photoService.AddPhotoAsync(gameVM.Image);

                var game = new Game
                {
                    Id = id,
                    Image = photoResult.Url.ToString(),
                    Title = gameVM.Title,
                    Description = gameVM.Description,
                    Price = gameVM.Price
                };

                _gameRepository.Update(game);

                return RedirectToAction("Index");
            }
            else
            {
                return View(gameVM);
            }
        }

    }
}
