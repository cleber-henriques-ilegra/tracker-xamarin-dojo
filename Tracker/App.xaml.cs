using System;
using Xamarin.Forms;

namespace Tracker
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			TrackerPage page = new TrackerPage();
			NavigationPage mainNavigation = new NavigationPage(page);
			MainPage = mainNavigation;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}


	}
}
