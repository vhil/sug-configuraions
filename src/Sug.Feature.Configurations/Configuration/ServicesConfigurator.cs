namespace Sug.Feature.Configurations.Configuration
{
	using Foundation.Rss.Configuration;
	using Microsoft.Extensions.DependencyInjection;
	using Sitecore.Configuration;
	using Sitecore.DependencyInjection;

	public class ServicesConfigurator : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton(provider =>
				Factory.CreateObject("feature/configurations/primaryRssFeed", false) as RssFeedSettings);
		}
	}
}

