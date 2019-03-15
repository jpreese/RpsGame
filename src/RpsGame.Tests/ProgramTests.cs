using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace RpsGame.Tests
{
  public class ProgramTests
  {
    public static IEnumerable<object[]> UserWins = new List<object[]>
    {
      new object[]{ThrowChoice.Rock, ThrowChoice.Scissors},
      new object[]{ThrowChoice.Paper, ThrowChoice.Rock},
      new object[]{ThrowChoice.Scissors, ThrowChoice.Paper}
    };

    public static IEnumerable<object[]> Ties = new List<object[]>
    {
      new object[]{ThrowChoice.Rock, ThrowChoice.Rock},
      new object[]{ThrowChoice.Paper, ThrowChoice.Paper},
      new object[]{ThrowChoice.Scissors, ThrowChoice.Scissors}
    };


    public static IEnumerable<object[]> ComputerWins = new List<object[]>
    {
      new object[]{ThrowChoice.Rock, ThrowChoice.Paper},
      new object[]{ThrowChoice.Paper, ThrowChoice.Scissors},
      new object[]{ThrowChoice.Scissors, ThrowChoice.Rock}
    };


    [Theory]
    [MemberData(nameof(UserWins))]
    public void Throw_Input_UserWins(ThrowChoice userChoice, ThrowChoice computerChoice)
    {
      Assert.EndsWith("User wins.", Program.Throw(userChoice, computerChoice));
    }

    [Theory]
    [MemberData(nameof(ComputerWins))]
    public void Throw_Input_ComputerWins(ThrowChoice userChoice, ThrowChoice computerChoice)
    {
      Assert.EndsWith("Computer wins.", Program.Throw(userChoice, computerChoice));
    }

    [Theory]
    [MemberData(nameof(Ties))]
    public void Throw_Input_Ties(ThrowChoice userChoice, ThrowChoice computerChoice)
    {
      Assert.EndsWith("Tie.", Program.Throw(userChoice, computerChoice));
    }
  }
}
