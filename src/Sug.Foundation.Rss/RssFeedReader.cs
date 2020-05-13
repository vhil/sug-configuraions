namespace Sug.Foundation.Rss
{
	using System;
	using Configuration;
	using Sitecore.Abstractions;

	public class RssFeedReader
	{
		protected readonly RssFeedSettings FeedSettings;
		protected readonly BaseLog Log;

		public RssFeedReader(
			RssFeedSettings feedSettings,
			BaseLog log)
		{
			this.FeedSettings = feedSettings;
			this.Log = log;
		}

		public virtual IRssFeed Read()
		{
			throw new NotImplementedException();
		}
	}
}