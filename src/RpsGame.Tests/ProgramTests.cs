using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace RpsGame.Tests
{
  public class ProgramTests
  {
    [Theory]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Scissors)]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Paper)]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Rock)]
    public void Throw_Input_UserWins(ThrowChoice userChoice, ThrowChoice computerChoice)
    {
      Assert.EndsWith("User wins.", Program.Throw(userChoice, computerChoice));
    }

    [Theory]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Paper)]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Rock)]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Scissors)]
    public void Throw_Input_ComputerWins(ThrowChoice userChoice, ThrowChoice computerChoice)
    {
      Assert.EndsWith("Computer wins.", Program.Throw(userChoice, computerChoice));
    }

    [Theory]
    [InlineData(ThrowChoice.Rock, ThrowChoice.Rock)]
    [InlineData(ThrowChoice.Scissors, ThrowChoice.Scissors)]
    [InlineData(ThrowChoice.Paper, ThrowChoice.Paper)]
    public void Throw_Input_Ties(ThrowChoice userChoice, ThrowChoice computerChoice)
    {
      Assert.EndsWith("Ties.", Program.Throw(userChoice, computerChoice));
    }
  }
}
