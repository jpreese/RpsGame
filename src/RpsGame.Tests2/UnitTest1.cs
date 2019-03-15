using System;
using System.Runtime.InteropServices;
using Xunit;

namespace RpsGame.Tests2
{
  public class UnitTest1
  {
    [Theory]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Rock, "Computer selected rock. Tie.")]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Rock, "Computer selected rock. User wins.")]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Rock, "Computer selected rock. Computer wins.")]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Paper, "Computer selected paper. Computer wins.")]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Paper, "Computer selected paper. Tie.")]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Paper, "Computer selected paper. User wins.")]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Scissors, "Computer selected scissors. User wins.")]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Scissors, "Computer selected scissors. Computer wins.")]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Scissors, "Computer selected scissors. Tie.")]
    public void ThrowProcess_GivenUserInputAndComputerInput_ReturnsResult(ThrowChoice input, ThrowChoice computerChoice,
      string result)
    {
      Assert.Equal(result, Program.ThrowProcessor(input, computerChoice));
    }

    [Theory]
    [InlineData('r', ThrowChoice.Rock)]
    [InlineData('p', ThrowChoice.Paper)]
    [InlineData('s', ThrowChoice.Scissors)]
    public void UserChoiceParser_GivenGoodInput_ReturnsCorrectValue(char input, ThrowChoice output)
    {
      Assert.Equal(output, new UserChoiceParser().ParseChoice(input));
    }

    [Fact]
    public void UserChoiceParser_GivenBadInput_AssertThrows()
    {
      Assert.Throws<ArgumentOutOfRangeException>(() => new UserChoiceParser().ParseChoice('a'));
    }
  }
}
