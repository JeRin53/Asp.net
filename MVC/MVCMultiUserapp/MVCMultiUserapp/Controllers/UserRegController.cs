using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCMultiUserapp.Models;
using System.Web.Mvc;
using System.IO;

namespace MVCMultiUserapp.Controllers
{
    public class UserRegController : Controller
    {
        MVCmultiuserEntities obj1 = new MVCmultiuserEntities();
        // GET: UserReg
        public ActionResult InsertUser_PageLoad()
        {
            return View();
        }
        public ActionResult InsertUser_Click(MVCMultiUserapp.Models.UserReg  clsobj,HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength>0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/Photos");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);
                    var fullpath = Path.Combine("~\\Photos", fname);
                    clsobj.Photo = fullpath;
                }
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
                obj1.sp_UserReg(regid, clsobj.Name,clsobj.Age, clsobj.Address, clsobj.Email,clsobj.Photo);
                obj1.sp_Loginsert(regid, clsobj.Username, clsobj.Pass, "user");
                clsobj.Usermsg = "Sucessfully inserted";
                return View("InsertUser_PageLoad", clsobj);
            }
            return View("InsertUser_PageLoad", clsobj);
        }
    }
}