using System;
using System.Runtime.InteropServices;
using Xunit;

namespace RpsGame.Tests2
{
  public class UnitTest1
  {
    [Theory]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Rock, Outcome.Tie, "Computer selected rock. Tie.")]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Rock, Outcome.Player1Wins, "Computer selected rock. User wins.")]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Rock, Outcome.Player2Wins, "Computer selected rock. Computer wins.")]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Paper, Outcome.Player2Wins, "Computer selected paper. Computer wins.")]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Paper, Outcome.Tie, "Computer selected paper. Tie.")]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Paper, Outcome.Player1Wins, "Computer selected paper. User wins.")]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Scissors, Outcome.Player1Wins, "Computer selected scissors. User wins.")]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Scissors, Outcome.Player2Wins, "Computer selected scissors. Computer wins.")]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Scissors, Outcome.Tie, "Computer selected scissors. Tie.")]
    public void ThrowProcess_GivenUserInputAndComputerInput_ReturnsResult(ThrowChoice input, ThrowChoice computerChoice, Outcome outcome,
      string result)
    {
      Assert.Equal(result, Program.ThrowProcessor(input, computerChoice, outcome));
    }

    [Theory]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Rock, Outcome.Tie)]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Rock, Outcome.Player1Wins)]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Rock, Outcome.Player2Wins)]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Paper, Outcome.Player2Wins)]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Paper, Outcome.Tie)]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Paper, Outcome.Player1Wins)]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Scissors, Outcome.Player1Wins)]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Scissors, Outcome.Player2Wins)]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Scissors, Outcome.Tie)]
    public void UserChoiceParser_GivenUserInputAndComputerInput_ReturnsResult(ThrowChoice input, ThrowChoice computerChoice,
      Outcome result)
    {
      Assert.Equal(result, new GameEngine().GenerateOutcome(input, computerChoice));
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
