using GamesRental.Controllers;
using GamesRental.Interfaces;
using GamesRental.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace GamesRental.Tests
{
    public class GameControllerTests
    {
        private readonly Mock<IGameRepository> _mockGameRepository;
        private readonly Mock<IPhotoService> _mockPhotoService;
        private readonly GameController _controller;

        public GameControllerTests()
        {
            _mockGameRepository = new Mock<IGameRepository>();
            _mockPhotoService = new Mock<IPhotoService>();
            _controller = new GameController(_mockGameRepository.Object, _mockPhotoService.Object, null);
        }

        [Fact]
        public async Task Index_Returns_ViewResult_With_List_Of_Games()
        {
            var games = new List<Game>
            {
                new Game { Id = 1, Title = "Game 1" },
                new Game { Id = 2, Title = "Game 2" }
            };

            _mockGameRepository.Setup(x => x.GetAll()).ReturnsAsync(games);

            var result = await _controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Game>>(viewResult.Model);
            Assert.Equal(2, model.Count());
        }

        [Fact]
        public async Task Detail_Returns_ViewResult_With_Game_Details()
        {
            var game = new Game { Id = 1, Title = "Game 1" };

            _mockGameRepository.Setup(x => x.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(game);

            var result = await _controller.Detail(1);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<Game>(viewResult.Model);
            Assert.Equal("Game 1", model.Title);
        }

        [Fact]
        public void Create_Returns_ViewResult()
        {
            var result = _controller.Create();

            var viewResult = Assert.IsType<ViewResult>(result);
        }
    }
}