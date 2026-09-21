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
    public partial class WebForm1 : System.Web.UI.Page
    {
        ConCls obj1 = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_db";
            //input parameters

            cmd.Parameters.AddWithValue("@na",TextBox1.Text);
            cmd.Parameters.AddWithValue("@ag", TextBox2.Text);
            cmd.Parameters.AddWithValue("@ad", TextBox3.Text);
            cmd.Parameters.AddWithValue("@us", TextBox4.Text);
            cmd.Parameters.AddWithValue("@ps", TextBox5.Text);

            //output parameters
            SqlParameter sp = new SqlParameter();
            sp.DbType = DbType.Int32;
            sp.ParameterName = "@status";
            sp.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sp);
            obj1.Fun_NonQuery(cmd);
            int outputval = Convert.ToInt32(sp.Value);
            if (outputval == 1)
            {
                Label1.Text = "Inserted";
            }
        }
    }
}