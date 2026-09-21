using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;

using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Doctor_Reg : System.Web.UI.Page
    {
        ConClass obj1 = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string str = "select Dept_Id,Dept_name from Dept_tab";
                DataSet ds= obj1.Fn_ExeDataAdapter(str);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Dept_name";
                DropDownList1.DataValueField = "Dept_Id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("Selected value","0"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));
            string ins = "insert into [Doc_Reg-tab] values("+DropDownList1.SelectedValue+",'" + TextBox1.Text + "'," + TextBox2.Text + "," + DropDownList1.SelectedValue + ",'"+path+"')";
            int i = obj1.Fn_ExecuteNonQuery(ins);

            if (i == 1)
            {
                Label1.Text = "inserted";
            }
            else
            {
                Label1.Text = "unsucessfull";
            }
        }
    }
}