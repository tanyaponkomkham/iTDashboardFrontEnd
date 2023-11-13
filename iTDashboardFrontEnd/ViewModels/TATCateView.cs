using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTDashboardFrontEnd.ViewModels
{
	public class TATCateView
	{
		public string year { get; set; }
		public string category { get; set; }
		public string short_month { get; set; }
		public int? mmonth { get; set; }
		public int? taTofCate { get; set; }
		public int? mgrApprove { get; set; }
		public int? pendingTime { get; set; }
		public int? itReview { get; set; }
		public int? userDiscussion { get; set; }
		public int? iTworking { get; set; }
		public Decimal? target { get; set; }
	}
}
