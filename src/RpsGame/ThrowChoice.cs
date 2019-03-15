using System.Linq;

namespace RpsGame
{
  public sealed class ThrowChoice
  {
    public static readonly ThrowChoice Rock;
    public static readonly ThrowChoice Paper;
    public static readonly ThrowChoice Scissors;
    public static readonly ThrowChoice Lizard;
    public static readonly ThrowChoice Spock;


    private readonly ThrowChoice[] _winsAgainst;

    static ThrowChoice()
    {
      ThrowChoice[] rockWins = new ThrowChoice[2];
      ThrowChoice.Rock = new ThrowChoice("rock", rockWins);

      ThrowChoice[] paperWins = new ThrowChoice[2];
      ThrowChoice.Paper = new ThrowChoice("paper", paperWins);

      ThrowChoice[] scissorsWins = new ThrowChoice[2];
      ThrowChoice.Scissors = new ThrowChoice("scissors", scissorsWins);

      ThrowChoice[] lizardWins = new ThrowChoice[2];
      ThrowChoice.Lizard = new ThrowChoice("lizard", lizardWins);

      ThrowChoice[] spockWins = new ThrowChoice[2];
      ThrowChoice.Spock = new ThrowChoice("Spock", spockWins);

      rockWins[0] = Scissors;
      rockWins[1] = Lizard;
      paperWins[0] = Rock;
      paperWins[1] = Spock;
      scissorsWins[0] = Paper;
      scissorsWins[1] = Lizard;
      lizardWins[0] = Spock;
      lizardWins[1] = Paper;
      spockWins[0] = Rock;
      spockWins[1] = Scissors;
    }

    private ThrowChoice(string name, ThrowChoice[] winsAgainst)
    {
      this.Name = name;
      _winsAgainst = winsAgainst;
    }

    public string Name { get; }

    public Outcome ThrowAgainst(ThrowChoice other)
    {
      if (this == other)
      {
        return Outcome.Tie;
      }

      return _winsAgainst.Contains(other) ? Outcome.Win : Outcome.Loss;
    }
  }
}
