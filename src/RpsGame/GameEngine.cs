using System;

namespace RpsGame
{
  public sealed class GameEngine
  {
    public Outcome GenerateOutcome(ThrowChoice playerOne, ThrowChoice playerTwo)
    {
      if (playerOne == playerTwo)
      {
        return Outcome.Tie;
      }

      if (playerOne == ThrowChoice.Rock)
      {
        if (playerTwo == ThrowChoice.Paper)
        {
          return Outcome.Player2Wins;
        }
        else if (playerTwo == ThrowChoice.Scissors)
        {
          return Outcome.Player1Wins;
        }
      }
      else if (playerOne == ThrowChoice.Paper)
      {
        if (playerTwo == ThrowChoice.Rock) { return Outcome.Player1Wins; }
        else if (playerTwo == ThrowChoice.Scissors) { return Outcome.Player2Wins; }
      }
      else if (playerOne == ThrowChoice.Scissors)
      {
        if (playerTwo == ThrowChoice.Rock) { return Outcome.Player2Wins; }
        else if (playerTwo == ThrowChoice.Paper) { return Outcome.Player1Wins; }
      }

      throw new Exception("You can't actually get here");
    }
  }
}
