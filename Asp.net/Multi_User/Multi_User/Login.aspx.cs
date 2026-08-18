using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multi_User
{
    public partial class Login : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select Count(Reg_Id) from Login_tab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'"; 
            string cid = obj1.Fn_ExeScalar(str);
            int i = Convert.ToInt32(cid);
            if (i == 1)
            {
                string str1 = "Select Reg_Id from Login_tab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string regid = obj1.Fn_ExeScalar(str1);
                Session["regid"] = regid;

                string str2 = "Select Log_Type from Login_tab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string logtype = obj1.Fn_ExeScalar(str2);
                if (logtype == "admin")
                {
                    Response.Redirect("AdminHome.aspx");
                }
                else if (logtype == "user")
                {
                    Response.Redirect("UserHome.aspx");
                }
                
            }
            else
            {
                Label1.Text = "Invalid Username and password";
            }
        }
    }
}