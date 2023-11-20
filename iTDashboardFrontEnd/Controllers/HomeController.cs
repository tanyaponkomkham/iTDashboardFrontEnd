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

		
		public ActionResult ChartTAT(string year,string mmonth)
		{
			TempData["Year"] = year;
			TempData["Month"] = mmonth;
			return PartialView();
		}
		public async Task<ActionResult> IndexChart2(string year)
		{
			List<TATView> getTATs = new List<TATView>();
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync("http://192.168.99.46:9028/api/TAT?year=" + year))
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
					getTATs = JsonConvert.DeserializeObject<List<TATView>>(apiResponse).ToList();
				}
			}
			return Json(getTATs);
		}
		[AcceptVerbs("Get", "Post")]
		public async Task<JsonResult> IndexChart3(GetTATCate getTATCate)
		{

			string[] monthArr = getTATCate.mmonth.Split(" ");
			List<TATCateView> getTATCates = new List<TATCateView>();
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync("http://192.168.99.46:9028/api/TAT/TATCate?year=" + getTATCate.year + "&mmonth=" + monthArr[0]))
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
					getTATCates = JsonConvert.DeserializeObject<List<TATCateView>>(apiResponse).ToList();
				}
			}
			return Json(getTATCates);
		}


		public ActionResult ChartOTD(string year, string target, string mmonth)
		{

			TempData["Year2"] = year;
			TempData["Target"] = target;
			TempData["Month2"] = mmonth;

			return PartialView();
		}
		public ActionResult ChartResultTargetTAT(string year, string target, string mmonth)
		{
			TempData["Year3"] = year;

			return PartialView();
		}
		public ActionResult ChartResultTargetOTD(string year, string target, string mmonth)
		{

			TempData["Year4"] = year;
			TempData["Target2"] = target;
			return PartialView();
		}
		[AcceptVerbs("Get", "Post")]
		public async Task<JsonResult> IndexChart4(GetOTD getOTD)
		{

		
			List<OTDView> getOTDs = new List<OTDView>();
			using (var httpClient = new HttpClient())
			{
				using (var response = await  httpClient.GetAsync("http://192.168.99.46:9028/api/OTD?year=" + getOTD.year + "&targert=" + getOTD.target ))
				{
					string apiResponse = await  response.Content.ReadAsStringAsync();
					getOTDs = JsonConvert.DeserializeObject<List<OTDView>>(apiResponse).ToList();
				}
			}
			return Json(getOTDs);
		}

		[AcceptVerbs("Get", "Post")]
		public async Task<JsonResult> IndexChart5(GetOTDCate getOTDCate)
		{

			string[] monthArr = getOTDCate.mmonth.Split(" ");
			List<OTDCateView> getOTDCates = new List<OTDCateView>();
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync("http://192.168.99.46:9028/api/OTD/OTDCate?year=" + getOTDCate.year + "&mmonth=" + monthArr[0] + "&target=" + getOTDCate.target))
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
					getOTDCates = JsonConvert.DeserializeObject<List<OTDCateView>>(apiResponse).ToList();
				}
			}
			return Json(getOTDCates);
		}

		public ActionResult TargetYear(string year)
		{

			TempData["Year3"] = year;
			
			return PartialView();
		}
		[AcceptVerbs("Get", "Post")]
		public async Task<JsonResult> GetTargetYear(GetTargetYear getTargetYear)
		{


			List<TargetView> getTargets = new List<TargetView>();
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync("http://192.168.99.46:9028/api/Target?yyear=" + getTargetYear.yyear ))
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
					getTargets = JsonConvert.DeserializeObject<List<TargetView>>(apiResponse).ToList();
				}
			}
			return Json(getTargets);
		}

		[AcceptVerbs("Get", "Post")]
		public async Task<JsonResult> GetYear()
		{

			List<YearView> getYears = new List<YearView>();
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync("http://192.168.99.46:9028/api/OTD/Year"))
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
					getYears = JsonConvert.DeserializeObject<List<YearView>>(apiResponse).ToList();
				}
			}
			return Json(getYears);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
