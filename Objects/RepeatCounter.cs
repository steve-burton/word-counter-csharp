using System;
using System.Collections.Generic;
using WordCounter.Objects;
using Xunit;

namespace WordCounter
{
	public class RepeatCounter
	{
		public int wordsCounted = 0;

		public int CountRepeats(string userWord, string userSentence)
		{
			string upperUserWord = userWord.ToUpper();
			string upperUserSentence = userSentence.ToUpper();
			string[] wordArray = upperUserSentence.Split(' ');
			wordsCounted = 0;

			foreach (string wordFound in wordArray)
			{
				if (wordFound == upperUserWord)
				{
					wordsCounted ++;
				}
			}
			return wordsCounted;
		}
	}
}
