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

		// string[] wordArray = UserSentence.Split(" ");
		// List<string> countList = new List<string>{};
		public string CountRepeats(string userWord, string userSentence)
		{
			this.UserWord = userWord;
			this.UserSentence = userSentence;
			string[] wordArray = this.UserSentence.Split();
			int wordsCounted = 0;
			string finalCount = "";

			// int wordsCounted = countList.Count;

			foreach (string wordFound in wordArray)
			if (wordFound == this.UserWord)
			{
				wordsCounted += 1;
				finalCount = wordsCounted.ToString();
			}
			return finalCount;
		}
	}
}
