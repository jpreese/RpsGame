using System;

namespace RpsGame
{
  public class Program
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

      int random = new Random().Next(1, 4);
      

      ThrowChoice computerChoice = ThrowChoice.Rock;

      switch (random)
      {
        case 1:
          computerChoice = ThrowChoice.Rock;
          break;
        case 2:
          computerChoice = ThrowChoice.Paper;
          break;
        case 3:
          computerChoice = ThrowChoice.Scissors;
          break;
      }

      Console.WriteLine(Program.Throw(userChoice, computerChoice));
    }

    public static string Throw(ThrowChoice userChoice, ThrowChoice computerChoice)
    {
      if (userChoice == ThrowChoice.Rock)
      {
        if (computerChoice == ThrowChoice.Rock) {return "Computer selected rock. Tie."; }
        else if (computerChoice == ThrowChoice.Paper) { return "Computer selected paper. Computer wins."; }
        else if (computerChoice == ThrowChoice.Scissors) { return "Computer selected scissors. User wins."; }
      }
      else if (userChoice == ThrowChoice.Paper)
      {
        if (computerChoice == ThrowChoice.Rock) { return "Computer selected rock. User wins."; }
        else if (computerChoice == ThrowChoice.Paper) { return "Computer selected paper. Tie."; }
        else if (computerChoice == ThrowChoice.Scissors) { return "Computer selected scissors. Computer wins."; }
      }
      else if (userChoice == ThrowChoice.Scissors)
      {
        if (computerChoice == ThrowChoice.Rock) { return "Computer selected rock. Computer wins."; }
        else if (computerChoice == ThrowChoice.Paper) { return "Computer selected paper. User wins."; }
        else if (computerChoice == ThrowChoice.Scissors) { return "Computer selected scissors. Tie."; }
      }

      return "Invalid selection. You fail.";
    }
  }
}
