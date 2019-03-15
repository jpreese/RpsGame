using System.Linq;

namespace RpsGame
{
  public sealed class ThrowChoice
  {
    public static readonly ThrowChoice Rock;
    public static readonly ThrowChoice Paper;
    public static readonly ThrowChoice Scissors;

    private readonly ThrowChoice[] _winsAgainst;
    private readonly ThrowChoice[] _losesAgainst;

    static ThrowChoice()
    {
      ThrowChoice[] rockWins = new ThrowChoice[1];
      ThrowChoice[] rockLoses = new ThrowChoice[1];
      ThrowChoice.Rock = new ThrowChoice("rock", rockWins, rockLoses);

      ThrowChoice[] paperWins = new ThrowChoice[1];
      ThrowChoice[] paperLoses = new ThrowChoice[1];
      ThrowChoice.Paper = new ThrowChoice("paper", paperWins, paperLoses);

      ThrowChoice[] scissorsWins = new ThrowChoice[1];
      ThrowChoice[] scissorsLoses = new ThrowChoice[1];
      ThrowChoice.Scissors = new ThrowChoice("scissors", scissorsWins, scissorsLoses);

      rockWins[0] = Scissors;
      paperWins[0] = Rock;
      scissorsWins[0] = Paper;

      rockLoses[0] = Paper;
      paperLoses[0] = Scissors;
      scissorsLoses[0] = Rock;
    }

    private ThrowChoice(string name, ThrowChoice[] winsAgainst, ThrowChoice[] losesAgainst)
    {
      this.Name = name;
      _winsAgainst = winsAgainst;
      _losesAgainst = losesAgainst;
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
