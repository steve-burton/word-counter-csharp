using System;
using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};
		}
	}
}
