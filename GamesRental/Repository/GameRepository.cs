using GamesRental.Data;
using GamesRental.Interfaces;
using GamesRental.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesRental.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _context;
        public GameRepository(AppDbContext context)
        {
            _context = context;

        }
        public bool Add(Game game)
        {
            _context.Add(game);
            return Save();
        }

        public bool Delete(Game game)
        {
            _context.Remove(game);
            return Save();
        }

        public async Task<IEnumerable<Game>> GetAll()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task<Game> GetByIdAsync(int id)
        {
            return await _context.Games.FirstOrDefaultAsync(x => x.Id == id);
            //return await _context.Games.Include(i => i.).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Game>> GetGameByTittle(string tittle)
        {
            return await _context.Games.Where(c => c.Title.Contains(tittle)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Game game)
        {
            _context.Update(game);
            return Save();
               
        }
    }
}
