using System;

namespace RpsGame
{
  class RandomChoiceMaker : IChoiceMaker
  {
    public ThrowChoice MakeChoice()
    {
      return (ThrowChoice)new Random().Next(1, 6);
    }
  }
}
