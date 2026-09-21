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
    public partial class EditCategory : System.Web.UI.Page
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
            string s = "select * from Category_tab";
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
            string del = "delete from Category_tab where Cat_Id=" + getid + "";
            obj1.Fn_ExecuteNonQuery(del);
            Display_Grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);

            TextBox txtname = (TextBox)GridView1.Rows[i].FindControl("TextBox1");
            TextBox txtdesc = (TextBox)GridView1.Rows[i].FindControl("TextBox2");
            FileUpload fu = (FileUpload)GridView1.Rows[i].FindControl("FileUpload1");
            DropDownList ddlstatus = (DropDownList)GridView1.Rows[i].FindControl("DropDownList1");

            if (fu != null && fu.HasFile)
            {
                string p = "~/img/" + fu.FileName;
                fu.SaveAs(MapPath(p));
                string strup = "update Category_tab set Cat_Name='" + txtname.Text + "', Cat_Description='" + txtdesc.Text + "', Cat_Image='" + p + "', Cat_Status='" + ddlstatus.SelectedItem.Text + "' where Cat_Id=" + getid + "";
                obj1.Fn_ExecuteNonQuery(strup);
            }
            else
            {
                string strup = "update Category_tab set Cat_Name='" + txtname.Text + "', Cat_Description='" + txtdesc.Text + "', Cat_Status='" + ddlstatus.SelectedItem.Text + "' where Cat_Id=" + getid + "";
                obj1.Fn_ExecuteNonQuery(strup);
            }

            GridView1.EditIndex = -1;
            Display_Grid();
        }
    }
}
