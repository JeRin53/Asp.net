using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvanceWebApplication.Models
{
    public class PwdCls
    {
        [Required(ErrorMessage = "Enter the old password")]
        public string oldpass { set; get; }
        [Required(ErrorMessage = "Enter the New Password")]
        public string newpass { set; get; }

        [Compare("newpass",ErrorMessage = "Password mismatch")]
        public string confnewpass { set; get; }
        public string msg { set; get; }
    }
}