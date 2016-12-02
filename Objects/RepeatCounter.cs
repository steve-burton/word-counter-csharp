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
		public string WordCount {get; set;}

		private static List<RepeatCounter> _instance = new List<RepeatCounter> {};

		public string CountRepeats(string userWord, string userSentence, string wordCount)
		{
			this.UserWord = userWord;
			this.UserSentence = userSentence;
			this.WordCount = wordCount;
			if (this.UserWord == this.UserSentence)
			{
				this.WordCount = "hello";
			}
			return this.WordCount;
		}
	}
}
