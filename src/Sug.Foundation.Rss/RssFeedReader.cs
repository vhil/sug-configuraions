namespace Sug.Foundation.Rss
{
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
			this.Log.Info($"Reading RSS feed from '{this.FeedSettings.FeedUrl}' with interval of {this.FeedSettings.Ttl}...", this);

			//TODO
			return null;
		}
	}
}