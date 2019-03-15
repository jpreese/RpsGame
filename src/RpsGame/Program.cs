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
