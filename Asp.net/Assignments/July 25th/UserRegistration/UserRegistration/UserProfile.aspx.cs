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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=JERINS-LEGION-7\SQLEXPRESS;database=DbJuly31;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string seldetails = "select name,age,address,phone,email,photo from UserRegister where Id=" + Session["uid"] + "";
                SqlCommand cmd = new SqlCommand(seldetails, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr["Name"].ToString();
                    TextBox2.Text = dr["Age"].ToString();
                    TextBox3.Text = dr["Address"].ToString();
                    TextBox4.Text = dr["phone"].ToString();
                    TextBox5.Text = dr["email"].ToString();
                    Image1.ImageUrl = dr["photo"].ToString();
                }
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strup = "update UserRegister set Age=" + TextBox2.Text + ",Address='" + TextBox3.Text + "' where Id= " + Session["uid"] + " "; 
            SqlCommand cmd = new SqlCommand(strup, con);
            con.Open();
            int i1 = cmd.ExecuteNonQuery();
            con.Close();
            if (i1 == 1)
            {
                Label7.Text = "Updated";
            }
            
        }
    }
}