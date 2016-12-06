using Xunit;
using System.Collections.Generic;
using System;
using WordCounter.Objects;

namespace WordCounter.Objects
{
  public class RepeatCounterTest
  {

    [Fact]
    public void CountRepeats_FindWordInSentenceReturnCount_1()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter();
      string userWord = "hello";
      string userSentence = "hello";

      //Act
      // int expected = 1;
      var result = testRepeatCounter.CountRepeats(userWord, userSentence);

      //Assert
      Assert.Equal(1, result);
    }

    [Fact]
    public void CountRepeats_FindMultipleMatchesInSentenceReturnCount_2()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter();
      string userWord = "hello";
      string userSentence = "hello world hello";

      //Act
      // int expected = 2;
      var result = testRepeatCounter.CountRepeats(userWord, userSentence);

      //Assert
      Assert.Equal(2, result);
    }

    [Fact]
    public void CountRepeats_FindMultipleMatchesUpperLower_2()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter();
      string userWord = "hello";
      string userSentence = "Hello world hello";

      //Act
      // int expected = 2;
      var result = testRepeatCounter.CountRepeats(userWord, userSentence);

      //Assert
      Assert.Equal(2, result);
    }
  }
}
