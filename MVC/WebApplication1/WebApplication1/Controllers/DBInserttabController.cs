using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DBInserttabController : Controller
    {
        MVCEntities obj1 = new MVCEntities();
        
        // GET: DBInserttab
        public ActionResult Inser_PageLoad()//load--new
        {
            return View();
        }
        public ActionResult Insert_Click(InsertCls clsobj)
        {
            if (ModelState.IsValid)
            {
                obj1.sp_InsertDB(clsobj.Name, clsobj.Age, clsobj.Email);
                clsobj.msg = "Inserted";
                return View("Inser_PageLoad", clsobj);
            }
            return View("Inser_PageLoad", clsobj);
        }
    }
}