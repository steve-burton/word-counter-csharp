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
		public int wordsCounted = 0;

		// string[] wordArray = UserSentence.Split(" ");
		string[] wordArray = UserSentence;
		// List<string> countList = new List<string>{};
		public CountRepeats(string userWord, string userSentence)
		{
			this.UserWord = userWord;
			this.UserSentence = userSentence;

			// int wordsCounted = countList.Count;

			foreach (string wordFound in wordArray)
			if (wordFound == this.UserWord)
			{
				wordsCounted += 1;
			}
			return wordsCounted;
		}
	}
}
