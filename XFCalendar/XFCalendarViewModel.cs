using System;
using System.Collections.ObjectModel;

namespace XFCalendar
{
	public class XFCalendarViewModel
	{

		public ObservableCollection<Model.Session> Sessions = new ObservableCollection<Model.Session> {
			new Model.Session{ Title = "Breakfast", Begin = DateTime.Parse("2012-10-10 08:00"), Finish = DateTime.Parse("2012-10-10 09:00") },
			new Model.Session{ Title = "Keynote", Begin = DateTime.Parse("2012-10-10 09:00"), Finish = DateTime.Parse("2012-10-10 09:50") },
			new Model.Session{ Title = "Morning Tea", Begin = DateTime.Parse("2012-10-10 10:00"), Finish = DateTime.Parse("2012-10-10 11:00") },
			new Model.Session{ Title = "Labs", Begin = DateTime.Parse("2012-10-10 11:00"), Finish = DateTime.Parse("2012-10-10 12:00") },
			new Model.Session{ Title = "Siesta", Begin = DateTime.Parse("2012-10-10 13:00"), Finish = DateTime.Parse("2012-10-10 13:50") },
			new Model.Session{ Title = "Afternoon Tea", Begin = DateTime.Parse("2012-10-10 14:00"), Finish = DateTime.Parse("2012-10-10 15:00") },
		};

		public XFCalendarViewModel ()
		{
		}
	}
}
