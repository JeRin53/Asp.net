using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project_1
{
    public partial class AddProduct : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load Category DropDownList from dbo.Category_tab
                string sel = "select Cat_Id, Cat_Name from Category_tab";
                DataSet ds = obj1.Fn_Adapter_Dataset(sel);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Cat_Name";
                DropDownList1.DataValueField = "Cat_Id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("-- Select Category --", "0"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string p = "~/img/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            // Insert into dbo.Product_tab (Prod_Id is Auto-Increment Identity)
            // Prod_Name, Cat_Id, Prod_price, Prod_Image, Prod_Description, Prod_Stock, Prod_Status
            string ins = "insert into Product_tab values('" + TextBox1.Text + "'," + DropDownList1.SelectedValue + "," + TextBox2.Text + ",'" + p + "','" + TextBox3.Text + "'," + TextBox4.Text + ",'" + DropDownList2.SelectedItem.Text + "')";
            int i = obj1.Fn_ExecuteNonQuery(ins);
            if (i == 1)
            {
                Label1.Text = "Product Added Successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                DropDownList1.SelectedIndex = 0;
            }
            else
            {
                Label1.Text = "Failed to Add Product";
            }
        }
    }
}
