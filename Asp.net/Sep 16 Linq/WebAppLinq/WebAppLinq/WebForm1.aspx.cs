using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppLinq
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] str = { "Red", "Green", "Blue", "Black", "Yellow", "White" };

            //select all values from an aray
            /*var all = from s in str select s;
            foreach(string s in all)
            {
                Response.Write(s + "<br>");
            }*/

            var matches = from s in str where s.Length > 4 select s;
            foreach(string s in matches)
            {
                Response.Write(s + "<br>");
            }

            //select item which starts with the given letter
            var strts = from s in str where s.StartsWith("B") select s;
            foreach (string s in matches)
            {
                Response.Write(s + "<br>");
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var even = from s in numbers where s % 2 == 0 select s;
            foreach(int s in even)
            {
                Response.Write(s+"<br>");
            }
        }
    }
}