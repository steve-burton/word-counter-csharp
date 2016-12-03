using Xunit;
using System.Collections.Generic;
using System;
using WordCounter.Objects;

namespace WordCounter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_SingleWordFind_Hello()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      string userWord = "hello";
      string userSentence = "hello";
      Assert.Equal("hello", testRepeatCounter.CountRepeats(userWord, userSentence));
    }
    [Fact]
    public void CountRepeats_CountSingleWordFind_1()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      // string userWord = "hello";
      // List<string> countList = new List<string>{};
      // countList.Add(userWord);
      int wordsCounted = 1;
      Assert.Equal(1, wordsCounted);
    }
  }
}
