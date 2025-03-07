using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Spreadsheet;

namespace EJ2MVCSampleBrowser.Controllers.Spreadsheet
{
    public partial class SpreadsheetController : Controller
    {
        public ActionResult ConditionalFormatting()
        {
            List<object> data = new List<object>()
            {
                new { ItemCode="AG940Z",  ItemName="Laser Printer",  Quantity="144",  PurchasePrice="169.50",  SellingPrice="172.00", Profit= "=E3-D3", LastUpdated ="5/25/19",  Rating="4.5" },
                new { ItemCode="BJ120K",  ItemName="Scientific Calculator",  Quantity="116",  PurchasePrice="21.80",  SellingPrice="23.00", Profit= "=E4-D4", LastUpdated="7/28/19",  Rating="4.0" },
                new { ItemCode="BC120M",  ItemName="Wired Keyboard",  Quantity="438",  PurchasePrice="26.80",  SellingPrice="29.00", Profit= "=E5-D5", LastUpdated="3/30/20",  Rating="4.25" },
                new { ItemCode="BS121L",  ItemName="Memory Card",  Quantity="486",  PurchasePrice="23.50",  SellingPrice="25.00", Profit= "=E6-D6", LastUpdated ="8/20/19",  Rating="3.5" },
                new { ItemCode="BU121K",  ItemName="Coffee Maker",  Quantity="176",  PurchasePrice="56.50",  SellingPrice="59.00", Profit= "=E7-D7", LastUpdated ="2/2/20",  Rating="4.5" },
                new { ItemCode="BD121M",  ItemName="Table Lamp",  Quantity="0",  PurchasePrice="22.50",  SellingPrice="25.00", Profit= "=E8-D8", LastUpdated ="11/11/19",  Rating="5.0" },
                new { ItemCode="AT992X",  ItemName="Document Scanner",  Quantity="116",  PurchasePrice="175.00",  SellingPrice="177.00", Profit= "=E9-D9", LastUpdated ="4/13/19",  Rating="4.75" },
                new { ItemCode="AP992Z",  ItemName="Gaming Headset",  Quantity="58",  PurchasePrice="32.00",  SellingPrice="35.00", Profit= "=E10-D10", LastUpdated ="2/14/20",  Rating="4.4" },
                new { ItemCode="AW920X",  ItemName="Laptop Bag",  Quantity="232",  PurchasePrice="18.90",  SellingPrice="19.00", Profit= "=E11-D11", LastUpdated ="6/10/19",  Rating="3.9" },
                new { ItemCode="AQ920Z",  ItemName="Table Fan",  Quantity="405",  PurchasePrice="33.90",  SellingPrice="35.00", Profit= "=E12-D12", LastUpdated ="5/28/19",  Rating="3.75" },
                new { ItemCode="AE940X",  ItemName="Electric Mop",  Quantity="47",  PurchasePrice="153.50",  SellingPrice="155.00", Profit= "=E13-D13", LastUpdated ="12/18/19",  Rating="3.9" },
                new { ItemCode="UI152C",  ItemName="Smart LED TV",  Quantity="232",  PurchasePrice="201.25",  SellingPrice="204.00", Profit= "=E14-D14", LastUpdated ="3/13/20",  Rating="4.35" },
                new { ItemCode="UD152V",  ItemName="Robotic Vacuum Cleaner",  Quantity="210",  PurchasePrice="182.25",  SellingPrice="185.00", Profit= "=E15-D15", LastUpdated ="8/26/19",  Rating="4.0" },
                new { ItemCode="BK120L",  ItemName="Gaming Mouse",  Quantity="225",  PurchasePrice="34.80",  SellingPrice="38.00", Profit= "=E16-D16", LastUpdated ="1/12/20",  Rating="4.2" },
                new { ItemCode="UF162V",  ItemName="Chair",  Quantity="373",  PurchasePrice="104.800",  SellingPrice="108.00", Profit= "=E17-D17", LastUpdated ="4/12/19",  Rating="3.25" },
                new { ItemCode="UR162C",  ItemName="Welding Gloves",  Quantity="216",  PurchasePrice="19.00",  SellingPrice="21.00", Profit= "=E18-D18", LastUpdated ="11/22/19",  Rating="3.85" },
            };
            ViewBag.ConditionalFormattingData = data;
            return View();
        }

        public ActionResult ConditionalFormattingOpen(OpenRequest openRequest)
        {
            return Content(Workbook.Open(openRequest));
        }

        public void ConditionalFormattingSave(SaveSettings saveSettings)
        {
            Workbook.Save(saveSettings);
        }
    }
}