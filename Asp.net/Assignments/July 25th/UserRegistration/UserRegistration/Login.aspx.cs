using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace UserRegistration
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=JERINS-LEGION-7\SQLEXPRESS;database=DbJuly31;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            string strin = "select Count(Id) from UserRegister where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(strin, con);
            con.Open();
            string cid=cmd.ExecuteScalar().ToString(); //count of id (cid)  
            con.Close();
            if (cid == "1")
            {
                string selid = "select Id from UserRegister where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "' ";
                SqlCommand cmd1 = new SqlCommand(selid, con);
                con.Open();
                string id = cmd1.ExecuteScalar().ToString();
                con.Close();
                Session["uid"] = id;
                Response.Redirect("UserProfile.aspx");
                Label3.Text = "Login Sucessull";
            }
            else
            {
                Label3.Text = "Invalid uname and pass";
            }
        }
    }
}