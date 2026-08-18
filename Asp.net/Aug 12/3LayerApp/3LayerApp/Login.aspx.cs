using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bill;

namespace _3LayerApp
{
    public partial class Login : System.Web.UI.Page
    {
        LoginCls obj1 = new LoginCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cid = obj1.GetCountId(TextBox1.Text, TextBox2.Text);
            if (cid == "1")
            {
                string id = obj1.GetId(TextBox1.Text, TextBox2.Text);
                Session["uid"] = id;
                Response.Redirect("ProfileDB.aspx");
                //Label1.Text = "sucess";
            }
            else
            {
                Label1.Text = "un sucess";
            }
        }
    }
}