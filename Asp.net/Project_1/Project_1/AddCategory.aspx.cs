using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class AddCategory : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/img/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins = "insert into Category_tab values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + p + "','" + DropDownList1.SelectedItem.Text + "')";
            int i = obj1.Fn_ExecuteNonQuery(ins);
            if (i == 1)
            {
                Label1.Text = "Category Added Successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            else
            {
                Label1.Text = "Failed to Add Category";
            }
        }
    }
}
