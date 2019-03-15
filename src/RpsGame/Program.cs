using System;

namespace RpsGame
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Rock Paper Scissors Lizard Spock");
      Console.WriteLine("-------------------");

      IChoiceMaker player1 = new ConsoleChoiceMaker();
      ThrowChoice player1Choice = player1.MakeChoice();

      Console.WriteLine("");

      IChoiceMaker player2 = new RandomChoiceMaker();
      ThrowChoice player2Choice = player2.MakeChoice();

      Outcome outcome = new GameEngine().GenerateOutcome(player1Choice, player2Choice);

      Console.WriteLine(ThrowProcessor(player1Choice, player2Choice, outcome));
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
