using System;
namespace Tracker
{
	public class Tracking
	{
		public String code;
		public String description;
		
		public Tracking()
		{
		}

		public Tracking(String code, String description)
		{
			this.code = code;
			this.description = description;
		}

		public string Code
		{
			get
			{
				return code;
			}

			set
			{
				code = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}

			set
			{
				description = value;
			}
		}
	}
}
