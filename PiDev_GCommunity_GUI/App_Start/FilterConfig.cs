﻿using System.Web;
using System.Web.Mvc;

namespace PiDev_GCommunity_GUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
