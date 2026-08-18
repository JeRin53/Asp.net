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
    public partial class ChangePass : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=JERINS-LEGION-7\SQLEXPRESS;database=DbJuly31;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string selpas = "select password from UserRegister where Id=" + Session["uid"] + "";
                SqlCommand cmd = new SqlCommand(selpas, con);
                con.Open();
                SqlDataReader pas = cmd.ExecuteReader();
                while (pas.Read())
                {
                    TextBox1.Text = pas["password"].ToString();
                }
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label4.Visible = true;
            Val1.Visible = true;
            string updpas = "update UserRegister set password='" + TextBox2.Text + "' where Id=" + Session["uid"] + "";
            SqlCommand cmd = new SqlCommand(updpas, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                Label4.Text = "Updated";
            }
        }
    }
}