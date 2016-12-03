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

		public string CountRepeats(string userWord, string userSentence)
		{
			this.UserWord = userWord;
			this.UserSentence = userSentence;
			string upperUserWord = this.UserWord.ToUpper();
			string upperUserSentence = this.UserSentence.ToUpper();
			string[] wordArray = upperUserSentence.Split();
			int wordsCounted = 0;
			string finalCount = "";

			foreach (string wordFound in wordArray)
			if (wordFound == upperUserWord)
			{
				wordsCounted += 1;
				finalCount = wordsCounted.ToString();
			}
			return finalCount;
		}
	}
}
