﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EJ2MVCSampleBrowser
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}