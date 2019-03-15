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
          Console.Write("Pick (r)ock, (p)aper, (s)cissors, (l)izzard, or Spoc(k): ");

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
            case 'l':
            case 'L':
              return ThrowChoice.Lizard;
            case 'k':
            case 'K':
              return ThrowChoice.Spock;
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
