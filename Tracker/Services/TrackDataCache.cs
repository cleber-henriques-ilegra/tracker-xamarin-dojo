using System;
using System.Collections.ObjectModel;

namespace Tracker
{
	public class TrackDataCache
	{
		private static TrackDataCache instance;

		private TrackDataCache() { }

		public ObservableCollection<Tracking> trackings = new ObservableCollection<Tracking>();

		public static TrackDataCache Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new TrackDataCache();
				}
				return instance;
			}
		}
	}
}
