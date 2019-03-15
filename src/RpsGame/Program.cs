using System;

namespace RpsGame
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Rock Paper Scissors");
      Console.WriteLine("-------------------");

      IChoiceMaker user = new ConsoleChoiceMaker();
      IChoiceMaker computer = new RandomChoiceMaker();

      Console.WriteLine(Program.Throw(user.GetChoice(), computer.GetChoice()));
    }

    public static string Throw(ThrowChoice userChoice, ThrowChoice computerChoice)
    {
      Outcome outcome = userChoice.ThrowAgainst(computerChoice);

      string outcomeLabel;

      switch (outcome)
      {
        case Outcome.Win:
          outcomeLabel = "User wins.";
          break;
        case Outcome.Loss:
          outcomeLabel = "Computer wins.";
          break;
        case Outcome.Tie:
        default:
          outcomeLabel = "Tie.";
          break;
      }

      return $"Computer selected {computerChoice.Name}. {outcomeLabel}";
    }
  }
}
