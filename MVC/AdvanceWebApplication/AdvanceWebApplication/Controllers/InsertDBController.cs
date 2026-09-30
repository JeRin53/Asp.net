using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdvanceWebApplication.Models;
using System.Web.Mvc;
using System.IO;

namespace AdvanceWebApplication.Controllers
{
    public class InsertDBController : Controller
    {
        MVC1Entities obj1 = new MVC1Entities();
        // GET: InsertDB
        public ActionResult Insert_PageLoad()
        {
            List<StClass> StList = new List<StClass>
            {
                new StClass{SId=1,SName="Kerala" },
                new StClass{SId=2,SName="Karnataka"},
                new StClass{SId=3,SName="TamilNadu"}
            };
            ViewBag.States = new SelectList(StList, "SID", "SName");
            //CHECK box list
            InsertCls obj = new InsertCls();
            obj.MyFavQual = getQualificationData();
            return View(obj);
        }

        public List<CheckBoxListHelper> getQualificationData()
        {
            List<CheckBoxListHelper> sts = new List<CheckBoxListHelper>()
            {
                new CheckBoxListHelper{Value="SSLC",Text="SSLC",IsChecked=true},
                new CheckBoxListHelper{Value="Plus Two",Text="Plus Two",IsChecked=false},
                new CheckBoxListHelper{Value="BCA",Text="BCA",IsChecked=false},
                new CheckBoxListHelper{Value="MCA",Text="MCA",IsChecked=false},
                new CheckBoxListHelper{Value="BTECH",Text="BTECH",IsChecked=false},
            };
            return sts;
        }

        public ActionResult Insert_Click(InsertCls clsobj,HttpPostedFileBase file,FormCollection form)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/photos");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);

                    var fullpath = Path.Combine("~//photos", fname);
                    clsobj.Photo = fullpath;
                }
                List<StClass> StList = new List<StClass>
            {
                new StClass{SId=1,SName="Kerala" },
                new StClass{SId=2,SName="Karnataka"},
                new StClass{SId=3,SName="TamilNadu"}
            };
                ViewBag.States = new SelectList(StList, "SID", "SName");

                int selectedId = Convert.ToInt32(form["ddlstate"]);
                StClass selectedItem = StList.FirstOrDefault(c => c.SId == selectedId);
                clsobj.SId = selectedItem.SId;
                clsobj.SName = selectedItem.SName;//set

                var quid = string.Join(",", clsobj.SelectedQual); // tojoin mulitple strings if mulitiple qulification is selected
                clsobj.Quali = quid; //set

                clsobj.MyFavQual = getQualificationData();//get

                obj1.sp_insertadv(clsobj.Name, clsobj.Age, clsobj.Address, clsobj.Email, clsobj.Photo, clsobj.Gender, clsobj.SName, clsobj.Quali, clsobj.Username, clsobj.Pwd);
                clsobj.msg = "sucessfully inserted";
                return View("Insert_PageLoad", clsobj);
            }
            else
            {
                List<StClass> StList = new List<StClass>
            {
                new StClass{SId=1,SName="Kerala" },
                new StClass{SId=2,SName="Karnataka"},
                new StClass{SId=3,SName="TamilNadu"}
            };
                ViewBag.States = new SelectList(StList, "SID", "SName");
                clsobj.MyFavQual = getQualificationData();
                return View("Insert_PageLoad", clsobj);
            }
        }
    }
}