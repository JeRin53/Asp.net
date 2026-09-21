using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project_1
{
    public partial class ViewBill : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Display_Bill_Details();
                Display_Order_Items();
            }
        }

        public void Display_Bill_Details()
        {
            // Join query from User_tab and Bill_tab to fetch user details (Name, Phone, Address, Email) and latest bill info (Grand Total, Date, Bill Id)
            string selUserBill = "SELECT dbo.User_tab.User_Name, dbo.User_tab.Phone, dbo.User_tab.Email, dbo.User_tab.Address, dbo.Bill_tab.Bill_Id, dbo.Bill_tab.Grand_Total, dbo.Bill_tab.Bill_Date FROM dbo.User_tab INNER JOIN dbo.Bill_tab ON dbo.User_tab.User_Id = dbo.Bill_tab.User_Id WHERE dbo.User_tab.User_Id=" + Session["regid"] + " ORDER BY dbo.Bill_tab.Bill_Id DESC";

            SqlDataReader dr = obj1.Fn_ExeReader(selUserBill);
            if (dr.Read())
            {
                lblUserName.Text = dr["User_Name"].ToString();
                lblPhone.Text = dr["Phone"].ToString();
                lblEmail.Text = dr["Email"].ToString();
                lblAddress.Text = dr["Address"].ToString();
                lblBillId.Text = "#INV-" + dr["Bill_Id"].ToString();
                lblBillDate.Text = Convert.ToDateTime(dr["Bill_Date"]).ToString("dd MMM yyyy");
                lblGrandTotal.Text = "$" + dr["Grand_Total"].ToString();
            }
        }

        public void Display_Order_Items()
        {
            // Join query between Order_tab and Product_tab to display ordered items, price, quantity, and subtotal
            string selOrders = "SELECT dbo.Product_tab.Prod_Name, dbo.Product_tab.Prod_price, dbo.Product_tab.Prod_Image, dbo.Order_tab.Ord_Quantity, dbo.Order_tab.Ord_Subtotal FROM dbo.Order_tab INNER JOIN dbo.Product_tab ON dbo.Order_tab.Prod_Id = dbo.Product_tab.Prod_Id WHERE dbo.Order_tab.User_Id=" + Session["regid"] + " AND dbo.Order_tab.Ord_Status='order'";

            DataSet ds = obj1.Fn_Adapter_Dataset(selOrders);
            gvBillItems.DataSource = ds;
            gvBillItems.DataBind();
        }

        protected void btnContinueShopping_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }
    }
}
