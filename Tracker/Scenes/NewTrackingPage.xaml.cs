using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tracker
{
	public partial class NewTrackingPage : ContentPage
	{

		private Tracking tracking = new Tracking();

		public NewTrackingPage()
		{
			InitializeComponent();
			Title = "New Tracker";
			ToolbarItems.Add(new ToolbarItem("Cancel", "", HandleCancel, ToolbarItemOrder.Default, 0));
			BindingContext = tracking;
		}

		void HandleCancel()
		{
			Navigation.PopModalAsync();
		}

		void HandleTrack_Clicked(object sender, System.EventArgs e)
		{
			TrackDataCache.Instance.trackings.Add(tracking);
			Navigation.PopModalAsync();
		}
	}
}
