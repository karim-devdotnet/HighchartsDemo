﻿using System.Web;
using System.Web.Mvc;

namespace Highcharts_4._0._1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}