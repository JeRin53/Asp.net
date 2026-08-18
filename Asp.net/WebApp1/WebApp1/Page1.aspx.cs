using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Page2.aspx?x=" + TextBox1.Text + "&b=" + TextBox2.Text + "");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Page3.aspx");
        }
    }
}