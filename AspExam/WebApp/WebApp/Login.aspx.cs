using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ConClass obj1 = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "Select Count(Login_Id) from Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "' ";
            string cid = obj1.Fn_ExeScalar(str).ToString();
            int i = Convert.ToInt32(cid);

            if (i == 1)
            {
                string str1 = "select Reg_id from Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "' ";
                string reg = obj1.Fn_ExeScalar(str1);
                Session["ureg"] = reg;
                string str2 = "Select Log_type from Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "' ";
                string log = obj1.Fn_ExeScalar(str2).ToString();
                if (log == "admin")
                {
                    Label1.Text = "Login Sucessfull as Admin";
                    Response.Redirect("Admin.aspx");
                }
                else if (log == "user")
                {
                    Label1.Text = "Logged in as User";
                    Response.Redirect("Doc_Home.aspx");

                }
                else
                {
                    Label1.Text = "login unsucess";
                }
            }
            else
            {
                Label1.Text = "Too many login profiles";
            }
        }
    }
}