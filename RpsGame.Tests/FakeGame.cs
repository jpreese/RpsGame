using System;

namespace RpsGame.Tests
{
    public class FakeGame : Game
    {
        public string ResultMessage;

        public Func<int> GetComputerChoiceStub { get; set; }
        public Func<ConsoleKeyInfo> GetUserInputStub { get; set; }

        protected override void DisplayResult(string message)
        {
            ResultMessage = message;
        }

        protected override ConsoleKeyInfo GetUserInput()
        {
            return GetUserInputStub();
        }

        protected override int GetComputerChoice()
        {
            return GetComputerChoiceStub();
        }
    }
}
