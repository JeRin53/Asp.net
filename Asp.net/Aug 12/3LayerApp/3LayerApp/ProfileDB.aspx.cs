using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using Bill;

namespace _3LayerApp
{
    public partial class ProfileDB : System.Web.UI.Page
    {
        ProfileCls obj1 = new Bill.ProfileCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(Session["uid"]);
            SqlDataReader dr = obj1.Fn_Getdata(uid);
            while (dr.Read())
            {
                Label1.Text = dr["name"].ToString();
                Label2.Text = dr["age"].ToString();
                Label3.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }


            DataSet ds = obj1.Fn_Getdata_Dataset(uid);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataTable da = obj1.Fn_Getdata_Datatable(uid);
            DataList1.DataSource = da;
            DataList1.DataBind();

        }
    }
}