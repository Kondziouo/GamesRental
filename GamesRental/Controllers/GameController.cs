using GamesRental.Data;
using GamesRental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamesRental.Controllers
{
    public class GameController : Controller
    {
        private readonly AppDbContext _context;

        public GameController (AppDbContext context)
        {
            _context = context;
        }


    
        public IActionResult Index()
        {
            List<Game> games = _context.Games.ToList();
            return View(games);
        }

        public IActionResult Detail(int id)
        {
            Game game = _context.Games.FirstOrDefault(x => x.Id == id);
            return View(game);
        }
        
    }
}
