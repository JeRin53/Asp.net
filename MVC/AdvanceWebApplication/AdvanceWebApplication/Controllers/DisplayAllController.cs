using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdvanceWebApplication.Models;
using System.Web.Mvc;

namespace AdvanceWebApplication.Controllers
{
    public class DisplayAllController : Controller
    {
        MVC1Entities obj1 = new MVC1Entities();
        // GET: DisplayAll
        public ActionResult Display_Pageload()
        {
            var data = obj1.sp_Selectall().ToList();
            ViewBag.userdetails = data;
            return View();
        }
    }
}