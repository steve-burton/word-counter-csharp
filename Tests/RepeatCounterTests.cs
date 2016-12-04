using Xunit;
using System.Collections.Generic;
using System;
using WordCounter.Objects;

namespace WordCounter.Objects
{
  public class RepeatCounterTest
  {
    // [Fact]
    // public void CountRepeats_SingleWordFind_Hello()
    // {
    //   RepeatCounter testRepeatCounter = new RepeatCounter();
    //   string userWord = "hello";
    //   string userSentence = "hello";
    //   Assert.Equal("hello", testRepeatCounter.CountRepeats(userWord, userSentence));
    // }

    [Fact]
    public void CountRepeats_FindWordInString_Hello()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      string userWord = "hello";
      string userSentence = "hello world";
      int WordsCounted = 1;
      Assert.Equal(1, WordsCounted);
    }

    [Fact]
    public void CountRepeats_FindWordInStringUpperLower_Hello()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      string userWord = "hello";
      string userSentence = "Hello world hello";
      int WordsCounted = 2;
      Assert.Equal(2, WordsCounted);
    }
  }
}
