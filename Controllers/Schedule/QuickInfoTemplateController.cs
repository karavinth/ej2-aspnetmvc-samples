﻿using EJ2MVCSampleBrowser.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult QuickInfoTemplate()
        {
            List<QuickInfoDataSourceModel> categories = new List<QuickInfoDataSourceModel>();
            categories.Add(new QuickInfoDataSourceModel { Name = "Jammy", Id = 1, Capacity = 20, Color = "#ea7a57", Type = "Conference" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Tweety", Id = 2, Capacity = 7, Color = "#7fa900", Type = "Cabin" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Nestle", Id = 3, Capacity = 5, Color = "#5978ee", Type = "Cabin" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Phoenix", Id = 4, Capacity = 15, Color = "#fec200", Type = "Conference" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Mission", Id = 5, Capacity = 25, Color = "#df5286", Type = "Conference" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Hangout", Id = 6, Capacity = 10, Color = "#00bdae", Type = "Cabin" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Rick Roll", Id = 7, Capacity = 20, Color = "#865fcf", Type = "Conference" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Rainbow", Id = 8, Capacity = 8, Color = "#1aaa55", Type = "Cabin" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Swarm", Id = 9, Capacity = 30, Color = "#df5286", Type = "Conference" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Photogenic", Id = 10, Capacity = 25, Color = "#710193", Type = "Conference" });
            ViewBag.Categories = categories;

            ViewBag.datasource = new ScheduleData().GetQuickInfoTemplateData();
            return View();
        }
    }
}
