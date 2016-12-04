using System;
using System.Collections.Generic;
using WordCounter.Objects;
using Xunit;

namespace WordCounter
{
	public class RepeatCounter
	{
		public string UserWord {get; set;}
		public string UserSentence {get; set;}
		public int wordsCounted {get; set;}

		public string CountRepeats(string userWord, string userSentence)
		{
			this.UserWord = userWord;
			this.UserSentence = userSentence;
			string upperUserWord = this.UserWord.ToUpper();
			string upperUserSentence = this.UserSentence.ToUpper();
			string[] wordArray = upperUserSentence.Split();
			wordsCounted = 0;
			string finalCount = "";

			for(int i = 0; i < wordArray.Length; i++)
			// foreach (string wordFound in wordArray)
			{
				if (wordArray[i] == upperUserWord)
				// if (wordFound == upperUserWord)
				{
					wordsCounted += 1;
					Console.WriteLine(wordsCounted);
					Console.WriteLine(upperUserWord);
					finalCount = wordsCounted.ToString();
				}
			}
			return finalCount;
		}
	}
}
