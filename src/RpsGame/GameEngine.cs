using System;
using System.Collections.Generic;

namespace RpsGame
{
  public sealed class GameEngine
  {
    private static readonly Dictionary<ThrowChoice, HashSet<ThrowChoice>> WinsAgainst = new Dictionary<ThrowChoice, HashSet<ThrowChoice>>();

    static GameEngine()
    {
      WinsAgainst[ThrowChoice.Paper] = new HashSet<ThrowChoice>() { ThrowChoice.Rock };
      WinsAgainst[ThrowChoice.Rock] = new HashSet<ThrowChoice>(){ ThrowChoice.Scissors};
      WinsAgainst[ThrowChoice.Scissors] = new HashSet<ThrowChoice>() { ThrowChoice.Paper };
    }

    public Outcome GenerateOutcome(ThrowChoice playerOne, ThrowChoice playerTwo)
    {
      if (playerOne == playerTwo)
      {
        return Outcome.Tie;
      }

      return WinsAgainst[playerOne].Contains(playerTwo) ? Outcome.Player1Wins : Outcome.Player2Wins;
    }
  }
}
