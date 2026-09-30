using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCMultiUserapp.Models;
using System.Web.Mvc;

namespace MVCMultiUserapp.Controllers
{
    public class LoginController : Controller
    {
        MVCmultiuserEntities obj1 = new MVCmultiuserEntities();
        // GET: Login
        public ActionResult Login_Pageload()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }
        public ActionResult Login_Click(Logincls objcls)
        {
            if (ModelState.IsValid)
            {
                var cid = obj1.sp_LoginCountId(objcls.Uname, objcls.password).First();
                if (cid == 1)
                {
                    var uid = obj1.sp_LoginId(objcls.Uname, objcls.password).FirstOrDefault();
                    Session["uid"] = uid;
                    var typ = obj1.sp_LoginType(objcls.Uname, objcls.password).FirstOrDefault();
                    if (typ == "user")
                    {
                        return RedirectToAction("Home");
                    }
                    else if(typ=="admin")
                    {
                        return RedirectToAction("Admin");
                    }
                    
                }
                else
                {
                    ModelState.Clear();
                    objcls.msg = "Invalid Username and Password";
                    return View("Login_Pageload", objcls);
                }
            }
            else
            {
                ModelState.Clear();
                objcls.msg = "Invalid Login";
                return View("Login_Pageload", objcls);
            }
            return View("Login_Pageload", objcls);
        }
    }
}