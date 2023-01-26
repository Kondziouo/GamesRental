using GamesRental.Models;

namespace GamesRental.Interfaces
{
    public interface IGameRepository
    {
        Task<IEnumerable<Game>> GetAll();
        Task<Game> GetByIdAsync(int id);
        Task<Game> GetByIdAsyncNoTracking(int id);
        Task<IEnumerable<Game>> GetGameByTittle(string tittle);
        bool Add (Game game);  
        bool Update (Game game);    
        bool Delete (Game game);
        bool Save();

    }
}
