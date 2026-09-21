using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Project_1
{
    public partial class ViewSingleProduct : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select * from Product_tab where Prod_Id=" + Session["Prod_Id"] + "";
                SqlDataReader dr = obj1.Fn_ExeReader(sel);
                while (dr.Read())
                {
                    lblProductName.Text = dr["Prod_Name"].ToString();
                    lblProductPrice.Text = dr["Prod_price"].ToString();
                    lblProductDescription.Text = dr["Prod_Description"].ToString();
                    imgProduct.ImageUrl = dr["Prod_Image"].ToString();

                    int stock = Convert.ToInt32(dr["Prod_Stock"]);
                    for (int i = 1; i <= stock; i++)
                    {
                        ddlQuantity.Items.Add(i.ToString());
                    }
                }
            }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(ddlQuantity.SelectedItem.Text);

            string sel = "select Prod_price from Product_tab where Prod_Id=" + Session["Prod_Id"] + "";
            string price = obj1.Fn_ExeScalar(sel);

            double subtotal = Convert.ToDouble(price) * qty;
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            string ins = "insert into Cart_tab values(" + Session["Prod_Id"] + "," + Session["regid"] + "," + qty + "," + subtotal + ",'" + date + "',1)";
            int i = obj1.Fn_ExecuteNonQuery(ins);
            if (i == 1)
            {
                lblCartMessage.Text = "Added to Cart Successfully";
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewcart.aspx");
        }
    }
}
