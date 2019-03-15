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

      var input = Console.ReadKey().KeyChar;

      Console.WriteLine("");

      int computerChoice = new Random().Next(1, 4); // 1 = rock, 2 = paper, 3 = scissors

      Console.WriteLine(ThrowProcessor(input, computerChoice));
    }

    public static string ThrowProcessor(char input, int computerChoice)
    {
      if (input == 'r')
      {
        if (computerChoice == 1)
        {
          return "Computer selected rock. Tie.";
        }
        else if (computerChoice == 2)
        {
          return "Computer selected paper. Computer wins.";
        }
        else if (computerChoice == 3)
        {
          return "Computer selected scissors. User wins.";
        }
      }
      else if (input == 'p')
      {
        if (computerChoice == 1)
        {
          return "Computer selected rock. User wins.";
        }
        else if (computerChoice == 2)
        {
          return "Computer selected paper. Tie.";
        }
        else if (computerChoice == 3)
        {
          return "Computer selected scissors. Computer wins.";
        }
      }
      else if (input == 's')
      {
        if (computerChoice == 1)
        {
          return "Computer selected rock. Computer wins.";
        }
        else if (computerChoice == 2)
        {
          return "Computer selected paper. User wins.";
        }
        else if (computerChoice == 3)
        {
          return "Computer selected scissors. Tie.";
        }
      }

      return "You all failed.";
    }
  }
}
