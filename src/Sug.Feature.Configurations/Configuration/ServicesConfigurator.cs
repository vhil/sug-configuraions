namespace Sug.Feature.Configurations.Configuration
{
	using Examples;
	using Foundation.Rss.Configuration;
	using Microsoft.Extensions.DependencyInjection;
	using Sitecore.Configuration;
	using Sitecore.DependencyInjection;

	public class ServicesConfigurator : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton<MyClass8>(provider => 
				Factory.CreateObject("feature/configurations/myclass8", false) as MyClass8);

			serviceCollection.AddSingleton(provider =>
				Factory.CreateObject("feature/configurations/primaryRssFeed", false) as RssFeedSettings);
		}
	}
}

