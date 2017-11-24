using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftSupply.Help.Areas.GanSoftPro.Content
{
    public class DefaultController : Controller
    {
        // GET: GanSoftPro/Default
        public ActionResult Index(string id = "", string key = "")
        {
            if (string.IsNullOrEmpty(id))
                return View();
            else
                return View($"{id}/{key}");
        }

    }
}