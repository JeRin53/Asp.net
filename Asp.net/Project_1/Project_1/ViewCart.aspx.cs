using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Data;

namespace Project_1
{
    public partial class ViewCart : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Display_Cart();
            }
        }

        public void Display_Cart()
        {
            string sel = "SELECT dbo.Cart_tab.Cart_Id, dbo.Product_tab.Prod_Name, dbo.Cart_tab.Cart_Quantity, dbo.Cart_tab.Cart_Subtotal," +
                " dbo.Product_tab.Prod_Image FROM dbo.Cart_tab INNER JOIN dbo.Product_tab ON dbo.Cart_tab.Prod_Id = dbo.Product_tab.Prod_Id WHERE dbo.Cart_tab.[User_Id]=" + Session["regid"] + " and dbo.Cart_tab.[Cart_Status]=1";
            DataSet ds = obj1.Fn_Adapter_Dataset(sel);
            gvCart.DataSource = ds;
            gvCart.DataBind();
        }

        protected void btnContinueShopping_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void gvCart_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvCart.EditIndex = e.NewEditIndex;
            Display_Cart();
        }

        protected void gvCart_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvCart.EditIndex = -1;
            Display_Cart();
        }

        protected void gvCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int cartid = Convert.ToInt32(gvCart.DataKeys[i].Value);
            string del = "delete from Cart_tab where Cart_Id=" + cartid + "";
            obj1.Fn_ExecuteNonQuery(del);
            Display_Cart();
        }

        protected void gvCart_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int cartid = Convert.ToInt32(gvCart.DataKeys[i].Value);

            TextBox txtqty = (TextBox)gvCart.Rows[i].FindControl("TextBox1");
            int qty = Convert.ToInt32(txtqty.Text);

            string selPrice = "select dbo.Product_tab.Prod_price from Cart_tab inner join Product_tab on Cart_tab.Prod_Id=Product_tab.Prod_Id where Cart_Id=" + cartid + "";
            string price = obj1.Fn_ExeScalar(selPrice);
            double subtotal = Convert.ToDouble(price) * qty;

            string up = "update Cart_tab set Cart_Quantity=" + qty + ", Cart_Subtotal=" + subtotal + " where Cart_Id=" + cartid + " and User_Id=" + Session["regid"] + "";
            obj1.Fn_ExecuteNonQuery(up);

            gvCart.EditIndex = -1;
            Display_Cart();
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string sel = "select Prod_Id from Cart_tab where User_Id=" + Session["regid"] + " and Cart_Status=1";
            SqlDataReader dr = obj1.Fn_ExeReader(sel);
            List<int> pdtlst = new List<int>();
            while (dr.Read())
            {
                pdtlst.Add(Convert.ToInt32(dr["Prod_Id"]));
            }

            if (pdtlst.Count == 0)
            {
                lblCartMessage.Text = "Your cart is empty. Please add items to confirm order.";
                return;
            }

            string date = DateTime.Now.ToString("yyyy-MM-dd");

            foreach (int pid in pdtlst)
            {
                string sel1 = "select Cart_Quantity, Cart_Subtotal from Cart_tab where Prod_Id=" + pid + " and User_Id=" + Session["regid"] + " and Cart_Status=1";
                SqlDataReader dr1 = obj1.Fn_ExeReader(sel1);
                int qun = 0;
                double subtot = 0;
                while (dr1.Read())
                {
                    qun = Convert.ToInt32(dr1["Cart_Quantity"]);
                    subtot = Convert.ToDouble(dr1["Cart_Subtotal"]);
                }

                string insOrder = "insert into Order_tab values(" + Session["regid"] + "," + pid + ",'" + date + "'," + qun + "," + subtot + ",'order')";
                obj1.Fn_ExecuteNonQuery(insOrder);

                string upCart = "update Cart_tab set Cart_Status=0 where Prod_Id=" + pid + " and User_Id=" + Session["regid"] + " and Cart_Status=1";
                obj1.Fn_ExecuteNonQuery(upCart);
            }

            string selSum = "select sum(Ord_Subtotal) from Order_tab where User_Id=" + Session["regid"] + " and Ord_Status='order'";
            string grandtot = obj1.Fn_ExeScalar(selSum);

            string selMaxOrd = "select max(Ord_Id) from Order_tab where User_Id=" + Session["regid"] + "";
            string maxOrdId = obj1.Fn_ExeScalar(selMaxOrd);

            string insBill = "insert into Bill_tab values(" + Session["regid"] + "," + maxOrdId + "," + grandtot + ",'" + date + "')";
            obj1.Fn_ExecuteNonQuery(insBill);

            Response.Redirect("viewbill.aspx");
        }
    }
}
