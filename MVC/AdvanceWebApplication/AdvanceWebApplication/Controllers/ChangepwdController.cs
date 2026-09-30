using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdvanceWebApplication.Models;
using System.Web.Mvc;

namespace AdvanceWebApplication.Controllers
{
    public class ChangepwdController : Controller
    {
        MVC1Entities obj1 = new MVC1Entities();
        // GET: Changepwd
        public ActionResult Password_Load()
        {
            int id = Convert.ToInt32(Session["uid"]);
            var getdata = obj1.sp_Getpwd(id).FirstOrDefault();
            return View(new PwdCls
            {
                oldpass=getdata
            });
        }

        public ActionResult Password_Update(PwdCls obj)
        {
            if (ModelState.IsValid)
            {
                int id = Convert.ToInt32(Session["uid"]);
                obj1.sp_Updatepwd(id, obj.newpass);
                return View("Password_Load", new PwdCls
                {
                    msg = "Password updated"
                });
            }
            return View("Password_Load", obj.msg = "Password Changed");
        }
    }
}
 