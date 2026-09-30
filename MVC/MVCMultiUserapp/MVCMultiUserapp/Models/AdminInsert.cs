using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCMultiUserapp.Models
{
    public class AdminInsert
    {
        [Required(ErrorMessage ="Enter the Name")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Enter the Address")]
        public string Address { set; get; }

        [Required(ErrorMessage = "Enter the Phone No.")]
        [RegularExpression(@"^(\d{10})$",ErrorMessage ="Enter valid Phone no.")]
        public string Phone { set; get; }

        [EmailAddress(ErrorMessage = "Enter valid mail id")]
        public string Email { set; get; }

        public string Username { set; get; }
        public string Pass { set; get; }
        [Compare("Pass",ErrorMessage ="Password mismatch")]
        public string Cpass { set; get; }
        public string Adminmsg { set; get; }
    }
}