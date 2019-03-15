using System;

namespace RpsGame
{
  public sealed class UserChoiceParser
  {
    public ThrowChoice ParseChoice(char input)
    {
      switch (input)
      {
        case 'r':
          return ThrowChoice.Rock;
        case 'p':
          return ThrowChoice.Paper;
        case 's':
          return ThrowChoice.Scissors;
        case 'l':
          return ThrowChoice.Lizard;
        case 'k':
          return ThrowChoice.Spock;
      }

      throw new ArgumentOutOfRangeException(nameof(input));
    }
  }
}
