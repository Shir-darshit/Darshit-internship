﻿using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_396
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
