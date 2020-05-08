namespace Sug.Feature.Configurations.Configuration
{
	using Examples;
	using Microsoft.Extensions.DependencyInjection;
	using Sitecore.Configuration;
	using Sitecore.DependencyInjection;

	public class ServicesConfigurator : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<MyClass8>(provider => 
				Factory.CreateObject("feature/configurations/myclass8", false) as MyClass8);
		}
	}
}

