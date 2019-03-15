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

      Outcome outcome = new GameEngine().GenerateOutcome(input, computerChoice);

      Console.WriteLine(ThrowProcessor(input, computerChoice, outcome));
    }

    public static string ThrowProcessor(ThrowChoice userChoice, ThrowChoice computerChoice, Outcome outcome)
    {
      switch (outcome)
      {
        case Outcome.Tie:
          return "Computer selected " + computerChoice.ToString().ToLower() + ". Tie.";
        case Outcome.Player1Wins:
          return "Computer selected " + computerChoice.ToString().ToLower() + ". User wins.";
        case Outcome.Player2Wins:
          return "Computer selected " + computerChoice.ToString().ToLower() + ". Computer wins.";
      }

      return "You all failed.";
    }
  }
}
