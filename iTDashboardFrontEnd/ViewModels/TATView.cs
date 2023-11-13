using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTDashboardFrontEnd.ViewModels
{
	public class TATView
	{
		public string JobYear { get; set; }
		public Decimal? mmonth { get; set; }
		public string short_month { get; set; }
		public Decimal? MgrApprove { get; set; }
		public Decimal? PendingTime { get; set; }
		public Decimal? ITReview { get; set; }
		public Decimal? UserDiscussion { get; set; }
		public Decimal? ITworking { get; set; }
		public Decimal? TAT { get; set; }
		public int? Target { get; set; }
	}
}
