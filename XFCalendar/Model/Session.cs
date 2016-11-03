using System;
namespace XFCalendar.Model
{
	public class Session
	{
		public Session ()
		{
		}

		public string Title { get; set; }
		public string Detail { get; set; }
		public DateTime Begin { get; set; }
		public DateTime Finish { get; set; }
	}
}
