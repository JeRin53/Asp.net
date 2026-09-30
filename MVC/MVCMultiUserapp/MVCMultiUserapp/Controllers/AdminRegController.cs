using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCMultiUserapp.Models;
using System.Web.Mvc;

namespace MVCMultiUserapp.Controllers
{
    public class AdminRegController : Controller
    {
        MVCmultiuserEntities obj1 = new MVCmultiuserEntities();
        // GET: AdminReg
        public ActionResult Insertadmin_PageLoad()
        {
            return View();
        }
        public ActionResult Insertadmin_Click(AdminInsert clsobj)
        {
            if (ModelState.IsValid)
            {
                var getmaxid = obj1.sp_MaxIdLogin().FirstOrDefault();
                int mid = Convert.ToInt32(getmaxid);
                int regid = 0;
                if (mid == 0)
                {
                    regid = 1;
                }
                else
                {
                    regid = mid + 1;
                }
                //get
                obj1.sp_adminReg(regid, clsobj.Name, clsobj.Address, clsobj.Phone, clsobj.Email);
                obj1.sp_Loginsert(regid, clsobj.Username, clsobj.Pass, "admin");
                clsobj.Adminmsg = "Sucessfully inserted";
                return View("Insertadmin_PageLoad", clsobj);
            }
            return View("Insertadmin_PageLoad", clsobj);
        }
    }
}