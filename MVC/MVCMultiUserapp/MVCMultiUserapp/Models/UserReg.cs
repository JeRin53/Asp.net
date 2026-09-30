using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCMultiUserapp.Models
{
    public class UserReg
    {
        [Required(ErrorMessage = "Enter the Name")]
        public string Name { set; get; }

        [Range(18,50,ErrorMessage = "Enter the Age")]
        public int Age { set; get; }

        [Required(ErrorMessage = "Enter the Address")]
        public string Address { set; get; }

        [EmailAddress(ErrorMessage = "Enter valid mail id")]
        public string Email { set; get; }

        public string Photo { set; get; }

        public string Username { set; get; }
        public string Pass { set; get; }
        [Compare("Pass", ErrorMessage = "Password mismatch")]
        public string Cpass { set; get; }
        public string Usermsg { set; get; }
    }
}