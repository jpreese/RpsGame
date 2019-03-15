using System;

namespace RpsGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Rock Paper Scissors");
      Console.WriteLine("-------------------");
      Console.Write("Pick (r)ock, (p)aper, or (s)cissors: ");

      ThrowChoice userChoice = ThrowChoice.Paper;

      switch (Console.ReadKey().KeyChar)
      {
        case 'r':
          userChoice = ThrowChoice.Rock;
          break;
        case 'p':
          userChoice = ThrowChoice.Paper;
          break;
        case 's':
          userChoice = ThrowChoice.Scissors;
          break;
      }

      
      Console.WriteLine("");

      ThrowChoice computerChoice = (ThrowChoice)new Random().Next(1, 4);

      if (userChoice == ThrowChoice.Rock)
      {
        if (computerChoice == ThrowChoice.Rock) { Console.WriteLine("Computer selected rock. Tie.");}
        else if (computerChoice == ThrowChoice.Paper) { Console.WriteLine("Computer selected paper. Computer wins."); }
        else if (computerChoice == ThrowChoice.Scissors) { Console.WriteLine("Computer selected scissors. User wins."); }
      }
      else if (userChoice == ThrowChoice.Paper)
      {
        if (computerChoice == ThrowChoice.Rock) { Console.WriteLine("Computer selected rock. User wins."); }
        else if (computerChoice == ThrowChoice.Paper) { Console.WriteLine("Computer selected paper. Tie."); }
        else if (computerChoice == ThrowChoice.Scissors) { Console.WriteLine("Computer selected scissors. Computer wins."); }
      }
      else if (userChoice == ThrowChoice.Scissors)
      {
        if (computerChoice == ThrowChoice.Rock) { Console.WriteLine("Computer selected rock. Computer wins."); }
        else if (computerChoice == ThrowChoice.Paper) { Console.WriteLine("Computer selected paper. User wins."); }
        else if (computerChoice == ThrowChoice.Scissors) { Console.WriteLine("Computer selected scissors. Tie."); }
      }
    }
  }
}
