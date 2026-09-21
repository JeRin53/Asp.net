using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        ConCls obj1 = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sb_login";

            cmd.Parameters.AddWithValue("@us", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pas", TextBox2.Text);
            string cid = obj1.Fun_Scalar(cmd);

            if (cid == "1")
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "Get_Id";

                cmd1.Parameters.AddWithValue("@us", TextBox1.Text);
                cmd1.Parameters.AddWithValue("@pw", TextBox2.Text);
                string id = obj1.Fun_Scalar(cmd1);
                Session["uid"] = id;
                Response.Redirect("ProfileView.aspx");
            }
            else
            {
                Label1.Text = "Invalid Username and pass";
            }
        }
    }
}