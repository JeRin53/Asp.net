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
    public partial class EditProduct : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Display_Grid();
            }
        }

        public void Display_Grid()
        {
            string s = "select * from Product_tab";
            DataSet ds = obj1.Fn_Adapter_Dataset(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Display_Grid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Display_Grid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from Product_tab where Prod_Id=" + getid + "";
            obj1.Fn_ExecuteNonQuery(del);
            Display_Grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);

            TextBox txtname = (TextBox)GridView1.Rows[i].FindControl("TextBox1");
            TextBox txtprice = (TextBox)GridView1.Rows[i].FindControl("TextBox2");
            TextBox txtstock = (TextBox)GridView1.Rows[i].FindControl("TextBox3");
            FileUpload fu = (FileUpload)GridView1.Rows[i].FindControl("FileUpload1");
            TextBox txtdesc = (TextBox)GridView1.Rows[i].FindControl("TextBox4");
            DropDownList ddlstatus = (DropDownList)GridView1.Rows[i].FindControl("DropDownList1");

            if (fu != null && fu.HasFile)
            {
                string p = "~/img/" + fu.FileName;
                fu.SaveAs(MapPath(p));
                string strup = "update Product_tab set Prod_Name='" + txtname.Text + "', Prod_price='" + txtprice.Text + "', Prod_Stock='" + txtstock.Text + "', Prod_Image='" + p + "', Prod_Description='" + txtdesc.Text + "', Prod_Status='" + ddlstatus.SelectedItem.Text + "' where Prod_Id=" + getid + "";
                obj1.Fn_ExecuteNonQuery(strup);
            }
            else
            {
                string strup = "update Product_tab set Prod_Name='" + txtname.Text + "', Prod_price='" + txtprice.Text + "', Prod_Stock='" + txtstock.Text + "', Prod_Description='" + txtdesc.Text + "', Prod_Status='" + ddlstatus.SelectedItem.Text + "' where Prod_Id=" + getid + "";
                obj1.Fn_ExecuteNonQuery(strup);
            }

            GridView1.EditIndex = -1;
            Display_Grid();
        }
    }
}
