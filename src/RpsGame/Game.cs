using System;
using System.Collections.Generic;
using System.Text;

namespace RpsGame
{
    public class Game
    {
        public void Run()
        {
            Console.WriteLine("Rock Paper Scissors");
            Console.WriteLine("-------------------");
            Console.Write("Pick (r)ock, (p)aper, or (s)cissors: ");

            var input = Console.ReadKey();

            Console.WriteLine("");

            int computerChoice = new Random().Next(1, 4); // 1 = rock, 2 = paper, 3 = scissors

            if (input.KeyChar == 'r')
            {
                if (computerChoice == 1)
                {
                    Console.WriteLine("Computer selected rock. Tie.");
                }
                else if (computerChoice == 2)
                {
                    Console.WriteLine("Computer selected paper. Computer wins.");
                }
                else if (computerChoice == 3)
                {
                    Console.WriteLine("Computer selected scissors. User wins.");
                }
            }
            else if (input.KeyChar == 'p')
            {
                if (computerChoice == 1)
                {
                    Console.WriteLine("Computer selected rock. User wins.");
                }
                else if (computerChoice == 2)
                {
                    Console.WriteLine("Computer selected paper. Tie.");
                }
                else if (computerChoice == 3)
                {
                    Console.WriteLine("Computer selected scissors. Computer wins.");
                }
            }
            else if (input.KeyChar == 's')
            {
                if (computerChoice == 1)
                {
                    Console.WriteLine("Computer selected rock. Computer wins.");
                }
                else if (computerChoice == 2)
                {
                    Console.WriteLine("Computer selected paper. User wins.");
                }
                else if (computerChoice == 3)
                {
                    Console.WriteLine("Computer selected scissors. Tie.");
                }
            }
        }
    }
}
