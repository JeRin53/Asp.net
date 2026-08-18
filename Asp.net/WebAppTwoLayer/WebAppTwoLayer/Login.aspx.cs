using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace WebAppTwoLayer
{
    public partial class Login : System.Web.UI.Page
    {
        ConnectionClass obj1 = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string lgin = "select Count(Id) from Twolayer where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string i = obj1.Fn_ExeScalar(lgin);
            if (i == "1")
            {
                string str = "select Id from Twolayer where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string a = obj1.Fn_ExeScalar(str);
                Session["uid"] = a;
                Label3.Text = "Login Sucessfull";
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
                Response.Redirect("ProfileView.aspx");
            }
            else
            {
                Label3.Text= "Login Unsucessfull"; 
            }
        }
    }
}