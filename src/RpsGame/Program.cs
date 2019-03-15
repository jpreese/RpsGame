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

      UserChoiceParser parser = new UserChoiceParser();

      ThrowChoice input;
      try
      {
        input = parser.ParseChoice(Console.ReadKey().KeyChar);
      }
      catch (ArgumentOutOfRangeException aex)
      {
        Console.WriteLine("You all failed.");
        return;
      }

      Console.WriteLine("");

      ThrowChoice computerChoice = (ThrowChoice)new Random().Next(1, 4); // 1 = rock, 2 = paper, 3 = scissors

      Console.WriteLine(ThrowProcessor(input, computerChoice));
    }

    public static string ThrowProcessor(ThrowChoice userChoice, ThrowChoice computerChoice)
    {
      if (userChoice == ThrowChoice.Rock)
      {
        if (computerChoice == ThrowChoice.Rock) { return "Computer selected rock. Tie."; }
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

      return "You all failed.";
    }
  }
}
