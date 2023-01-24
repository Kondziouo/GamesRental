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
        
    }
}
