using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdvanceWebApplication.Models;
using System.Web.Mvc;

namespace AdvanceWebApplication.Controllers
{
    public class UserProfileDBController : Controller
    {
        MVC1Entities obj1 = new MVC1Entities();
        // GET: UserProfileDB
        public ActionResult Profile_Load()
        {
            int id = Convert.ToInt32(Session["uid"]);
            var getdata = obj1.sp_Profile(id).FirstOrDefault();
            return View(new ProfileCls
            {
                name = getdata.Name,
                age=getdata.Age,
                address=getdata.Address,
                email=getdata.Email,
                photo=getdata.Photo
            });
        }

        public ActionResult Profile_Update(ProfileCls obj)
        {
            int id = Convert.ToInt32(Session["uid"]);
            obj1.sp_Profile_Update(id, obj.age, obj.address);
            var getdata = obj1.sp_Profile(id).FirstOrDefault();
            return View("Profile_Load",new ProfileCls
            {
                name = getdata.Name,
                age = getdata.Age,
                address = getdata.Address,
                email = getdata.Email,
                photo = getdata.Photo,
                msg="Profile updated"
            });
        }


    }
}