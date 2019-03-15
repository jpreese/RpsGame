using System;

namespace RpsGame
{
  public sealed class ConsoleChoiceMaker : IChoiceMaker
  {
    public ThrowChoice GetChoice()
    {
      try
      {
        while (true)
        {
          Console.Write("Pick (r)ock, (p)aper, or (s)cissors: ");

          switch (Console.ReadKey().KeyChar)
          {
            case 'r':
            case 'R':
              return ThrowChoice.Rock;
            case 'p':
            case 'P':
              return ThrowChoice.Paper;
            case 's':
            case 'S':
              return ThrowChoice.Scissors;
            default:
              Console.WriteLine("Invalid input. Try again.");
              break;
          }
        }
      }
      finally
      {
        Console.WriteLine("");
      }
    }
  }
}
