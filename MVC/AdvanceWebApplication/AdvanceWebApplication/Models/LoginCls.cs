using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvanceWebApplication.Models
{
    public class LoginCls
    {
        [Required(ErrorMessage ="Enter the user name")]
        public string Uname { set; get; }
        [Required(ErrorMessage = "Enter the Password")]
        public string password { set; get; }
        public string msg { set; get; }
    }
}