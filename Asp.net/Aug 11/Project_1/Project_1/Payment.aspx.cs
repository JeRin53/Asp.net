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
    public partial class Payment : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Fetch latest grand total from Bill_tab for current user
                string selBill = "select top 1 Grand_Total from Bill_tab where User_Id=" + Session["regid"] + " order by Bill_Id desc";
                string grandtot = obj1.Fn_ExeScalar(selBill);
                if (!string.IsNullOrEmpty(grandtot))
                {
                    lblPayableAmount.Text = "₹" + grandtot;
                    Session["Grand_Total"] = grandtot;
                }
            }
        }

        // Check if Account Number exists on TextChanged
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string sel = "select count(Acc_No) from Account_tab where Acc_No='" + TextBox1.Text.Trim() + "'";
            string count = obj1.Fn_ExeScalar(sel);
            if (Convert.ToInt32(count) > 0)
            {
                lblAccCheck.Text = "Account number already exists!";
                lblAccCheck.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblAccCheck.Text = "Account number available.";
                lblAccCheck.ForeColor = System.Drawing.Color.Green;
            }
        }

        // Insert new account details into Account_tab
        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select count(Acc_No) from Account_tab where Acc_No='" + TextBox1.Text.Trim() + "'";
            string count = obj1.Fn_ExeScalar(sel);
            if (Convert.ToInt32(count) > 0)
            {
                lblAccMsg.Text = "Account number already exists! Cannot insert duplicate.";
                lblAccMsg.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Schema: Account_tab(User_Id, Acc_Type, Acc_No, Balance_Amount)
            string ins = "insert into Account_tab(User_Id, Acc_Type, Acc_No, Balance_Amount) values(" + Session["regid"] + ",'" + TextBox2.Text.Trim() + "','" + TextBox1.Text.Trim() + "'," + TextBox3.Text.Trim() + ")";
            int i = obj1.Fn_ExecuteNonQuery(ins);
            if (i == 1)
            {
                lblAccMsg.Text = "Account Details Saved Successfully!";
                lblAccMsg.ForeColor = System.Drawing.Color.Green;
                TextBox4.Text = TextBox1.Text.Trim(); // Auto fill in payment section
            }
            else
            {
                lblAccMsg.Text = "Failed to save account details.";
                lblAccMsg.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Process Payment via WCF Service and update Order Status & Product Stock
        protected void Button2_Click(object sender, EventArgs e)
        {
            string accNo = TextBox4.Text.Trim();

            // 1. Fetch payable Grand Total
            string selBill = "select top 1 Grand_Total from Bill_tab where User_Id=" + Session["regid"] + " order by Bill_Id desc";
            string grandtotStr = obj1.Fn_ExeScalar(selBill);
            if (string.IsNullOrEmpty(grandtotStr))
            {
                lblPayMsg.Text = "No active bill found for payment.";
                lblPayMsg.ForeColor = System.Drawing.Color.Red;
                return;
            }
            double grandTotal = Convert.ToDouble(grandtotStr);

            // 2. Call WCF Service to check Account Balance
            ServiceReference1.ServiceClient wcfObj = new ServiceReference1.ServiceClient();
            string balStr = wcfObj.CheckBalance(accNo);
            if (string.IsNullOrEmpty(balStr))
            {
                lblPayMsg.Text = "Invalid Account Number! Account does not exist.";
                lblPayMsg.ForeColor = System.Drawing.Color.Red;
                return;
            }

            double balance = Convert.ToDouble(balStr);

            // 3. If balance is sufficient, debit amount and update order status & stock
            if (balance >= grandTotal)
            {
                // Reduce balance in account using WCF
                wcfObj.UpdateBalance(accNo, grandTotal);

                // 4. Select product IDs from Order_tab where user_id = session and status = 'order'
                string selPdt = "select Prod_Id from Order_tab where User_Id=" + Session["regid"] + " and Ord_Status='order'";
                SqlDataReader dr = obj1.Fn_ExeReader(selPdt);
                List<int> lstpdtid = new List<int>();
                while (dr.Read())
                {
                    lstpdtid.Add(Convert.ToInt32(dr["Prod_Id"]));
                }

                // 5. Update each ordered item to 'paid' and reduce product stock
                foreach (int pid in lstpdtid)
                {
                    // Update order status to paid
                    string upOrder = "update Order_tab set Ord_Status='paid' where User_Id=" + Session["regid"] + " and Ord_Status='order' and Prod_Id=" + pid + "";
                    obj1.Fn_ExecuteNonQuery(upOrder);

                    // Select current stock from Product_tab
                    string selStock = "select Prod_Stock from Product_tab where Prod_Id=" + pid + "";
                    string oldStockStr = obj1.Fn_ExeScalar(selStock);
                    int oldstock = Convert.ToInt32(oldStockStr);

                    // Select quantity from Order_tab
                    string selQty = "select Ord_Quantity from Order_tab where User_Id=" + Session["regid"] + " and Prod_Id=" + pid + " and Ord_Status='paid'";
                    string qtyStr = obj1.Fn_ExeScalar(selQty);
                    int quantity = Convert.ToInt32(qtyStr);

                    // Reduce stock in Product_tab
                    int newstock = oldstock - quantity;
                    string upStock = "update Product_tab set Prod_Stock=" + newstock + " where Prod_Id=" + pid + "";
                    obj1.Fn_ExecuteNonQuery(upStock);
                }

                lblPayMsg.Text = "Payment of ₹" + grandTotal + " Successful! Order status updated to PAID and stock updated.";
                lblPayMsg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblPayMsg.Text = "Insufficient Balance in Account! Current Balance: ₹" + balance;
                lblPayMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
