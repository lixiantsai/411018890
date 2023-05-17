using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411018890.Controllers
{
    public class WaterController : Controller
    {
        // GET: Water
        public ActionResult Index(string name,float? weight)
        {
            var ret = "";
            if (weight.HasValue)
                ret = (weight * 30) + "cc";
            ViewBag.Name = name;
            ViewBag.Result = ret;
            return View();
        }
    }
}