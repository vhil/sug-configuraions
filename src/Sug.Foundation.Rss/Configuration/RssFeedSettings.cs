namespace Sug.Foundation.Rss.Configuration
{
	using System;

	public class RssFeedSettings
	{
		public string FeedUrl { get; protected set; }
		public string RssRefreshTtlMinutes { get; protected set; }
		public TimeSpan Ttl => TimeSpan.FromMinutes(int.Parse(this.RssRefreshTtlMinutes));
	}
}