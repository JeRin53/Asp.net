using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project_1
{
    public partial class UserHome : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_Categories();
            }
        }

        public void Bind_Categories()
        {
            string s = "select * from Category_tab where Cat_Status='Available'";
            DataSet ds = obj1.Fn_Adapter_Dataset(s);
            dlCategories.DataSource = ds;
            dlCategories.DataBind();
        }

        protected void imgBtnCategory_Command(object sender, CommandEventArgs e)
        {
            int categoryId = Convert.ToInt32(e.CommandArgument);
            Session["Cat_Id"] = categoryId;
            Response.Redirect("viewallproducts.aspx");
        }
    }
}
