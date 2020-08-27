using Highsoft.Web.Mvc.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Highcharts_8._2._0.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BasicColumn()
        {
            List<double> tokyoValues = new List<double> { 49.9, 71.5, 106.4, 129.2, 144.0, 176.0, 135.6, 148.5, 216.4, 194.1, 95.6, 54.4 };
            List<double> nyValues = new List<double> { 83.6, 78.8, 98.5, 93.4, 106.0, 84.5, 105.0, 104.3, 91.2, 83.5, 106.6, 92.3 };
            List<double> berlinValues = new List<double> { 42.4, 33.2, 34.5, 39.7, 52.6, 75.5, 57.4, 60.4, 47.6, 39.1, 46.8, 51.1 };
            List<double> londonValues = new List<double> { 48.9, 38.8, 39.3, 41.4, 47.0, 48.3, 59.0, 59.6, 52.4, 65.2, 59.3, 51.2 };
            List<ColumnSeriesData> tokyoData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> nyData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> berlinData = new List<ColumnSeriesData>();
            List<ColumnSeriesData> londonData = new List<ColumnSeriesData>();

            tokyoValues.ForEach(p => tokyoData.Add(new ColumnSeriesData { Y = p }));
            nyValues.ForEach(p => nyData.Add(new ColumnSeriesData { Y = p }));
            berlinValues.ForEach(p => berlinData.Add(new ColumnSeriesData { Y = p }));
            londonValues.ForEach(p => londonData.Add(new ColumnSeriesData { Y = p }));

            ViewData["tokyoData"] = tokyoData;
            ViewData["nyData"] = nyData;
            ViewData["berlinData"] = berlinData;
            ViewData["londonData"] = londonData;


            return View();
        }

        public ActionResult BasicLine()
        {
            List<int> installationValues = new List<int> { 43934, 52503, 57177, 69658, 97031, 119931, 137133, 154175 };
            List<int> manufacturingValues = new List<int> { 24916, 24064, 29742, 29851, 32490, 30282, 38121, 40434 };
            List<int> salesAnDistributionValues = new List<int> { 11744, 17722, 16005, 19771, 20185, 24377, 32147, 39387 };
            List<int> projectDevelopmentValues = new List<int> { 0, 0, 7988, 12169, 15112, 22452, 34400, 34227 };
            List<int> otherValues = new List<int> { 12908, 5948, 8105, 11248, 8989, 11816, 18274, 18111 };
            List<LineSeriesData> installationData = new List<LineSeriesData>();
            List<LineSeriesData> manufacturingData = new List<LineSeriesData>();
            List<LineSeriesData> salesAnDistributionData = new List<LineSeriesData>();
            List<LineSeriesData> projectDevelopmentData = new List<LineSeriesData>();
            List<LineSeriesData> otherData = new List<LineSeriesData>();

            installationValues.ForEach(p => installationData.Add(new LineSeriesData { Y = p }));
            manufacturingValues.ForEach(p => manufacturingData.Add(new LineSeriesData { Y = p }));
            salesAnDistributionValues.ForEach(p => salesAnDistributionData.Add(new LineSeriesData { Y = p }));
            projectDevelopmentValues.ForEach(p => projectDevelopmentData.Add(new LineSeriesData { Y = p }));
            otherValues.ForEach(p => otherData.Add(new LineSeriesData { Y = p }));


            ViewData["installationData"] = installationData;
            ViewData["manufacturingData"] = manufacturingData;
            ViewData["salesAnDistributionData"] = salesAnDistributionData;
            ViewData["projectDevelopmentData"] = projectDevelopmentData;
            ViewData["otherData"] = otherData;

            return View();
        }
    }
}