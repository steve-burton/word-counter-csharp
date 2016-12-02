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
      //UserInput newInput = new UserInput();
      RepeatCounter testRepeatCounter = new RepeatCounter();
      string userWord = "hello";
      string userSentence = "hello";
      string wordCount = "hello";
      Assert.Equal("hello", testRepeatCounter.CountRepeats(userWord, userSentence, wordCount));
    }
  }
}
