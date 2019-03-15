using System;

namespace RpsGame
{
  public sealed class RandomChoiceMaker : IChoiceMaker
  {
    private readonly Random _rand = new Random();
    public ThrowChoice GetChoice()
    {
      int random = new Random().Next(1, 6);

      switch (random)
      {
        case 1:
          return ThrowChoice.Rock;
        case 2:
          return ThrowChoice.Paper;
        case 3:
          return ThrowChoice.Scissors;
        case 4:
          return ThrowChoice.Lizard;
        case 5:
        default:
          return ThrowChoice.Spock;
      }
    }
  }
}
