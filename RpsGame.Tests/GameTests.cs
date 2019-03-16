using Xunit;
using System;

namespace RpsGame.Tests
{
    public class GameTests
    {
        [Fact]
        public void Game_UserChoosesRockAndComputerChoosesRock_ResultIsTie()
        {
            var game = new FakeGame();
            game.GetUserInputStub = () => CreateRockInputForUser();
            game.GetComputerChoiceStub = () => 1;

            game.Run();

            Assert.Equal("Computer selected rock. Tie.", game.ResultMessage);
        }

        private ConsoleKeyInfo CreateRockInputForUser()
        {
            return new ConsoleKeyInfo('r', ConsoleKey.R, false, false, false);
        }
    }
}
