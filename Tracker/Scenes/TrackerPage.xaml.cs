using System;
using Xamarin.Forms;

namespace Tracker
{
	public partial class TrackerPage : ContentPage
	{

		public TrackerPage()
		{
			InitializeComponent();
			Title = "Tracking List";
			ToolbarItems.Add(new ToolbarItem("Add", "", HandleAdd, ToolbarItemOrder.Primary, 0));

			BindingContext = TrackDataCache.Instance.trackings;
		}

		void HandleAdd()
		{
			//Console.WriteLine("Add pressed");
			NavigationPage navigation = new NavigationPage(new NewTrackingPage());
			Navigation.PushModalAsync(navigation);
		}
	}


}
