using System.Runtime.InteropServices;
using Xunit;

namespace RpsGame.Tests2
{
  public class UnitTest1
  {
    [Theory]
    [InlineData('r', 1, "Computer selected rock. Tie.")]
    [InlineData('p', 1, "Computer selected rock. User wins.")]
    [InlineData('s', 1, "Computer selected rock. Computer wins.")]
    [InlineData('r', 2, "Computer selected paper. Computer wins.")]
    [InlineData('p', 2, "Computer selected paper. Tie.")]
    [InlineData('s', 2, "Computer selected paper. User wins.")]
    [InlineData('r', 3, "Computer selected scissors. User wins.")]
    [InlineData('p', 3, "Computer selected scissors. Computer wins.")]
    [InlineData('s', 3, "Computer selected scissors. Tie.")]
    [InlineData('a', 1, "You all failed.")]
    public void ThrowProcess_GivenUserInputAndComputerInput_ReturnsResult(char input, int computerChoice,
      string result)
    {
      Assert.Equal(result, Program.ThrowProcessor(input, computerChoice));
    }
  }
}
