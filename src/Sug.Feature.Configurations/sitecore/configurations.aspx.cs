namespace Sug.Feature.Configurations.sitecore
{
	using System;
	using System.Web.UI;
	using Examples;
	using Foundation.Rss;
	using Foundation.Rss.Configuration;
	using Sitecore.Configuration;
	using Sitecore.DependencyInjection;
	using Microsoft.Extensions.DependencyInjection;
	using Sitecore.Abstractions;

	public partial class Configurations : Page
	{
		protected override void OnLoad(EventArgs e)
		{
			var myclass1 =  Factory.CreateObject("feature/configurations/myclass1", false) as MyClass1;

			#region more examples

			var myclass2 =  Factory.CreateObject("feature/configurations/myclass2", false) as MyClass2;
			var myclass3 =  Factory.CreateObject("feature/configurations/myclass3", false) as MyClass3;
			var myclass4 =  Factory.CreateObject("feature/configurations/myclass4", false) as MyClass4;
			var myclass5 =  Factory.CreateObject("feature/configurations/myclass5", false) as MyClass5;
			var myclass6 =  Factory.CreateObject("feature/configurations/myclass6", false) as MyClass6;
			var myclass7 =  Factory.CreateObject("feature/configurations/myclass7", false) as MyClass7;
			var myclass8 =  Factory.CreateObject("feature/configurations/myclass8", false) as MyClass8;
			var myclass9 =  Factory.CreateObject("feature/configurations/myclass9", false) as MyClass9;
			var myclass91 = Factory.CreateObject("feature/configurations/myclass91", false) as MyClass9;

			#endregion

			#region rss feeds

			var defaultRssReader = ServiceLocator.ServiceProvider.GetService<RssFeedReader>();

			var altReader = new RssFeedReader(
				Factory.CreateObject("feature/configurations/alternativeRssFeed", true) as RssFeedSettings,
				ServiceLocator.ServiceProvider.GetService<BaseLog>());

			#endregion

			base.OnLoad(e);
		}
	}
}