﻿using System.Web;
using System.Web.Mvc;

namespace KLTN_QL_KTX
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
