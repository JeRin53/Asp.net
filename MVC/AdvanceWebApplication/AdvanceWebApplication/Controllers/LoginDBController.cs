using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdvanceWebApplication.Models;
using System.Web.Mvc;
using System.Data.Entity.Core.Objects;

namespace AdvanceWebApplication.Controllers
{
    public class LoginDBController : Controller
    {
        MVC1Entities obj1 = new MVC1Entities();
        // GET: LoginDB


        public ActionResult Login_Pageload()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Login_Click(LoginCls objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                obj1.sp_login(objcls.Uname, objcls.password, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    int uid = Convert.ToInt32(obj1.sp_Getid(objcls.Uname, objcls.password).First());
                    Session["uid"]=uid;
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.Clear();
                    objcls.msg = "Invalid Login";
                    return View("Login_Pageload", objcls);
                }
            }
            return View("Login_Pageload",objcls);
        }
    }
}