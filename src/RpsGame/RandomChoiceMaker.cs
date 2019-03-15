using System;

namespace RpsGame
{
  public sealed class RandomChoiceMaker : IChoiceMaker
  {
    private readonly Random _rand = new Random();
    public ThrowChoice GetChoice()
    {
      int random = new Random().Next(1, 4);

      switch (random)
      {
        case 1:
          return ThrowChoice.Rock;
        case 2:
          return ThrowChoice.Paper;
        case 3:
        default:
          return ThrowChoice.Scissors;
      }
    }
  }
}
