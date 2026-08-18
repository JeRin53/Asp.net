using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Aug_06
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="aa" && TextBox2.Text == "aa")
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                Label3.Text = "Invalid";
            }
        }
    }
}