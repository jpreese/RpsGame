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
      new object[]{ThrowChoice.Rock, ThrowChoice.Lizard},
      new object[]{ThrowChoice.Paper, ThrowChoice.Rock},
      new object[]{ThrowChoice.Paper, ThrowChoice.Spock},
      new object[]{ThrowChoice.Scissors, ThrowChoice.Paper},
      new object[]{ThrowChoice.Scissors, ThrowChoice.Lizard},
      new object[]{ThrowChoice.Lizard, ThrowChoice.Paper},
      new object[]{ThrowChoice.Lizard, ThrowChoice.Spock},
      new object[]{ThrowChoice.Spock, ThrowChoice.Scissors},
      new object[]{ThrowChoice.Spock, ThrowChoice.Rock}
    };

    public static IEnumerable<object[]> Ties = new List<object[]>
    {
      new object[]{ThrowChoice.Rock, ThrowChoice.Rock},
      new object[]{ThrowChoice.Paper, ThrowChoice.Paper},
      new object[]{ThrowChoice.Scissors, ThrowChoice.Scissors},
      new object[]{ThrowChoice.Lizard, ThrowChoice.Lizard},
      new object[]{ThrowChoice.Spock, ThrowChoice.Spock}
    };


    public static IEnumerable<object[]> ComputerWins = new List<object[]>
    {
      new object[]{ThrowChoice.Scissors, ThrowChoice.Rock},
      new object[]{ThrowChoice.Lizard, ThrowChoice.Rock},
      new object[]{ThrowChoice.Rock, ThrowChoice.Paper},
      new object[]{ThrowChoice.Spock, ThrowChoice.Paper},
      new object[]{ThrowChoice.Paper, ThrowChoice.Scissors},
      new object[]{ThrowChoice.Lizard, ThrowChoice.Scissors},
      new object[]{ThrowChoice.Paper, ThrowChoice.Lizard},
      new object[]{ThrowChoice.Spock, ThrowChoice.Lizard},
      new object[]{ThrowChoice.Scissors, ThrowChoice.Spock},
      new object[]{ThrowChoice.Rock, ThrowChoice.Spock}
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
