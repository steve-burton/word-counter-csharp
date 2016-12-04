using System;
using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter.Objects
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};
			Post["/results"] = _ =>
			{
				string userWord = Request.Form["search-word"];
				string userSentence = Request.Form["sentence"];
				int wordsCounted = 0;
				RepeatCounter newRepeatCounter = new RepeatCounter();
				// string finalCount = wordsCounted.ToString();
				return View["results.cshtml", newRepeatCounter];
			};
		}
	}
}
