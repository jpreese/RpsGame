using System;
using System.Collections.Generic;
using System.Text;

namespace RpsGame
{
  class ConsoleChoiceMaker : IChoiceMaker
  {
    public ThrowChoice MakeChoice()
    {
      Console.Write("Pick (r)ock, (p)aper, (s)cissors, (l)izard, or Spoc(k): ");

      UserChoiceParser parser = new UserChoiceParser();

      try
      {
        return parser.ParseChoice(Console.ReadKey().KeyChar);
      }
      catch (ArgumentOutOfRangeException aex)
      {
        Console.WriteLine("You all failed.");
        throw;
      }
    }
  }
}
