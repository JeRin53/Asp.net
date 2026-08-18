using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebAppTwoLayer
{
    public partial class ProfileView : System.Web.UI.Page
    {
        ConnectionClass obj1 = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select name,age,address,photo from twolayer where id=" + Session["uid"] + "";
            SqlDataReader dr = obj1.Fn_ExeReader(sel);
            while (dr.Read())
            {
                Label1.Text = dr["name"].ToString();
                Label2.Text = dr["age"].ToString();
                Label3.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }

            DataSet ds = obj1.Fn_Adapter_Dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();


            DataTable dt = obj1.Fn_Adapter_Datatable(sel);
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
    }
}