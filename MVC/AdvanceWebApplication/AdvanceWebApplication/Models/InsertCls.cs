using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvanceWebApplication.Models
{
    public class StClass
    {
        public int SId { set; get; }
        public string SName { set; get; }
    }
    public class CheckBoxListHelper
    {
        public string Value { set; get; }
        public string Text { set; get; }
        public bool IsChecked { set; get; }
    }
    public class InsertCls
    {
        //DDL(drop down list)
        public int SId { set; get; }
        public string SName { set; get; }

        //CBL(check Box List )
        public List<CheckBoxListHelper> MyFavQual { set; get; }//data save and bind CBL
        public string[] SelectedQual { set; get; }//selected qualidications save using an array



        [Required(ErrorMessage ="Enter the name")]
        public string Name { set; get; }

        [Range(18,50,ErrorMessage ="Enter the Age")]
        public int Age { set; get; }
        [Required(ErrorMessage = "Enter the Address")]
        public string Address { set; get; }

        [EmailAddress(ErrorMessage = "Enter valid mail")]
        [Required(ErrorMessage = "Enter the Mail id")]
        public string Email { set; get; }

        public string Photo { set; get; }
        public string Gender { set; get; }
        public string Quali { set; get; }
        public string Username { set; get; }
        public string Pwd { set; get; }
        [Compare("Pwd",ErrorMessage ="Password Mismatch")]
        public string Cpass { set; get; }
        public string msg { set; get; }

    }
}