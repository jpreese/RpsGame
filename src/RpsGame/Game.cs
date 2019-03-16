using System;

namespace RpsGame
{
    public class Game
    {
        public void Run()
        {
            Console.WriteLine("Rock Paper Scissors");
            Console.WriteLine("-------------------");
            Console.Write("Pick (r)ock, (p)aper, or (s)cissors: ");

            var input = GetUserInput();

            Console.WriteLine("");

            int computerChoice = GetComputerChoice();

            if (input.KeyChar == 'r')
            {
                if (computerChoice == 1)
                {
                    DisplayResult("Computer selected rock. Tie.");
                }
                else if (computerChoice == 2)
                {
                    DisplayResult("Computer selected paper. Computer wins.");
                }
                else if (computerChoice == 3)
                {
                    DisplayResult("Computer selected scissors. User wins.");
                }
            }
            else if (input.KeyChar == 'p')
            {
                if (computerChoice == 1)
                {
                    DisplayResult("Computer selected rock. User wins.");
                }
                else if (computerChoice == 2)
                {
                    DisplayResult("Computer selected paper. Tie.");
                }
                else if (computerChoice == 3)
                {
                    DisplayResult("Computer selected scissors. Computer wins.");
                }
            }
            else if (input.KeyChar == 's')
            {
                if (computerChoice == 1)
                {
                    DisplayResult("Computer selected rock. Computer wins.");
                }
                else if (computerChoice == 2)
                {
                    DisplayResult("Computer selected paper. User wins.");
                }
                else if (computerChoice == 3)
                {
                    DisplayResult("Computer selected scissors. Tie.");
                }
            }
        }

        protected virtual void DisplayResult(string message)
        {
            Console.WriteLine(message);
        }

        protected virtual ConsoleKeyInfo GetUserInput()
        {
            return Console.ReadKey();
        }

        protected virtual int GetComputerChoice()
        {
            return new Random().Next(1, 4);
        }
    }
}
