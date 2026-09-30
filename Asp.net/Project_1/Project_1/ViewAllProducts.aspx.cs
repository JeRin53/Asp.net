using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project_1
{
    public partial class ViewAllProducts : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_Products();
            }
        }

        public void Bind_Products()
        {
            if (Session["Cat_Id"] != null)
            {
                string s = "select * from Product_tab where Cat_Id=" + Session["Cat_Id"] + " and Prod_Status='Available'";
                DataSet ds = obj1.Fn_Adapter_Dataset(s);
                dlProducts.DataSource = ds;
                dlProducts.DataBind();
            }
            else
            {
                string s = "select * from Product_tab where Prod_Status='Available'";
                DataSet ds = obj1.Fn_Adapter_Dataset(s);
                dlProducts.DataSource = ds;
                dlProducts.DataBind();
            }
        }

        protected void imgBtnProduct_Command(object sender, CommandEventArgs e)
        {
            int productId = Convert.ToInt32(e.CommandArgument);
            Session["Prod_Id"] = productId;
            Response.Redirect("viewsingleproduct.aspx");
        }
    }
}
