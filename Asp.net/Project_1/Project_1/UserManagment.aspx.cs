using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class UserManagment : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                display();
            }
        }
        public void display()
        {
            string sel = "select * from User_tab ";
            DataSet ds = obj1.Fn_Adapter_Dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            display();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            display();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int userid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            RadioButtonList rb = (RadioButtonList)GridView1.Rows[i].FindControl("RadioButtonList1");
            string status = rb.SelectedValue;
            string up = "update User_tab set User_Status='"+status+"' where User_Id='"+userid+"'";
            obj1.Fn_ExecuteNonQuery(up);
            GridView1.EditIndex = -1;
            display();
        }
    }
}