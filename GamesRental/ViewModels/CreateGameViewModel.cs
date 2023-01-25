using GamesRental.Models;


namespace GamesRental.ViewModels
{
    public class CreateGameViewModel
    {
        public int Id { get; set; }
        public IFormFile Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
