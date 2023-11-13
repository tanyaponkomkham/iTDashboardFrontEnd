using iTDashboardFrontEnd.Models;
using iTDashboardFrontEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace iTDashboardFrontEnd.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public ActionResult IndexTable3(GetTATCate getTATCate)
		{
			ViewBag.Year = getTATCate.year;
			ViewBag.Month = getTATCate.mmonth;
			return PartialView();
		}
		[AcceptVerbs("Get", "Post")]
		public async Task<JsonResult> IndexChart3(GetTATCate getTATCate)
		{
			string[] monthArr = getTATCate.mmonth.Split(" ");
			List<TATCateView> getTATCates = new List<TATCateView>();
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync("https://localhost:44390/api/TAT/TATCate?year=" + getTATCate.year + "&mmonth=" + monthArr[0]))
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
					getTATCates = JsonConvert.DeserializeObject<List<TATCateView>>(apiResponse).ToList();
				}
			}
			return Json(getTATCates);
		}
		public ActionResult IndexTable2(string year)
		{
			ViewBag.Year = year;
			return PartialView();
		}
		public async Task<ActionResult> IndexChart2(string year)
		{
			List<TATView> getTATs = new List<TATView>();
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync("https://localhost:44390/api/TAT?year=" + year))
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
					getTATs = JsonConvert.DeserializeObject<List<TATView>>(apiResponse).ToList();
				}
			}
			return Json(getTATs);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
