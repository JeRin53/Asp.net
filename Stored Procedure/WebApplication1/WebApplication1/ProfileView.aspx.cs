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
    public partial class ProfileView : System.Web.UI.Page
    {
        ConCls obj1 = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_profview";

                cmd.Parameters.AddWithValue("@id", Session["uid"]);
                SqlDataReader dr = obj1.Fun_Reader(cmd);
                while (dr.Read())
                {
                    TextBox1.Text = dr["Name"].ToString();
                    TextBox2.Text = dr["Age"].ToString();
                    TextBox3.Text = dr["Address"].ToString();
                    TextBox4.Text = dr["Username"].ToString();
                }

                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "sp_selectall";
                DataSet ds = obj1.Fun_Adapter(cmd2);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_profileupdate";

            cmd.Parameters.AddWithValue("@id", Session["uid"]);
            cmd.Parameters.AddWithValue("@na", TextBox1.Text);
            cmd.Parameters.AddWithValue("@ag", TextBox2.Text);
            cmd.Parameters.AddWithValue("@ad", TextBox3.Text);
            cmd.Parameters.AddWithValue("@us", TextBox4.Text);

            obj1.Fun_NonQuery(cmd);
            Label1.Text = "Updated sucessfully";
        }
    }
}