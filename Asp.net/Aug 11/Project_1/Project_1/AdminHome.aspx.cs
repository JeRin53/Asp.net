using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project_1
{
    public partial class AdminHome : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCategoryGrid();
            }
        }
        public void BindCategoryGrid()
        {
            string sel = "select Cat_Id, Cat_Name, Cat_Description, Cat_Image, Cat_Status from Category_tab";
            DataSet ds = obj1.Fn_Adapter_Dataset(sel);
            gvCategories.DataSource = ds;
            gvCategories.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("addcategory.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("addproduct.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditCategory.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProduct.aspx");
        }
    }
}
