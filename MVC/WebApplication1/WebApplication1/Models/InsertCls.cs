using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class InsertCls
    {
        [Required(ErrorMessage ="Enter the Name")]
        public string Name
        {
            set;
            get;
        }
        [Range(20,60,ErrorMessage ="Enter valid Age")]
        public int Age
        {
            set;
            get;
        }
        [EmailAddress(ErrorMessage ="Enter Valid Mailid")]
        public string Email
        {
            set;
            get;
        }
        public string msg { set; get; }
    }
}