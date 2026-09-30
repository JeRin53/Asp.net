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
                // Fetchinf grand total 
                string selBill = "select top 1 Grand_Total from Bill_tab where User_Id=" + Session["regid"] + " order by Bill_Id desc";
                string grandtot = obj1.Fn_ExeScalar(selBill);
                if (!string.IsNullOrEmpty(grandtot))
                {
                    lblPayableAmount.Text = "₹" + grandtot;
                    Session["Grand_Total"] = grandtot;
                }
            }
        }

        // Checking if Account Number exists
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

        // Inserting
        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select count(Acc_No) from Account_tab where Acc_No='" + TextBox1.Text.Trim() + "'";
            string count = obj1.Fn_ExeScalar(sel);
            if (Convert.ToInt32(count) > 0)
            {
                lblAccMsg.Text = "Account number already exists! Cannot insert duplicate.";
                lblAccMsg.ForeColor = System.Drawing.Color.Red;
                ClientScript.RegisterStartupScript(this.GetType(), "AccAlert", "alert('Account number already exists! Cannot insert duplicate.');", true);
                return;
            }

            string ins = "insert into Account_tab values(" + Session["regid"] + ",'" + TextBox2.Text.Trim() + "','" + TextBox1.Text.Trim() + "'," + TextBox3.Text.Trim() + ")";
            int i = obj1.Fn_ExecuteNonQuery(ins);
            if (i == 1)
            {
                lblAccMsg.Text = "Account Details Saved Successfully!";
                lblAccMsg.ForeColor = System.Drawing.Color.Green;
                TextBox4.Text = TextBox1.Text.Trim(); 
                ClientScript.RegisterStartupScript(this.GetType(), "AccAlert", "alert('Account Details Saved Successfully!\\nAccount Number: " + TextBox1.Text.Trim() + "\\nInitial Balance: ₹" + TextBox3.Text.Trim() + "');", true);
            }
            else
            {
                lblAccMsg.Text = "Failed to save account details.";
                lblAccMsg.ForeColor = System.Drawing.Color.Red;
                ClientScript.RegisterStartupScript(this.GetType(), "AccAlert", "alert('Failed to save account details. Please try again.');", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string accNo = TextBox4.Text.Trim();

            //Fetching Grand Total
            string selBill = "select top 1 Grand_Total from Bill_tab where User_Id=" + Session["regid"] + " order by Bill_Id desc";
            string grandtotStr = obj1.Fn_ExeScalar(selBill);
            if (string.IsNullOrEmpty(grandtotStr))
            {
                lblPayMsg.Text = "No active bill found for payment.";
                lblPayMsg.ForeColor = System.Drawing.Color.Red;
                ClientScript.RegisterStartupScript(this.GetType(), "PaymentAlert", "alert('No active bill found for payment.');", true);
                return;
            }
            double grandTotal = Convert.ToDouble(grandtotStr);

            // Calling WCF Service to check Account Balance
            ServiceReference1.ServiceClient wcfObj = new ServiceReference1.ServiceClient();
            string balStr = wcfObj.CheckBalance(accNo);
            if (string.IsNullOrEmpty(balStr))
            {
                lblPayMsg.Text = "Invalid Account Number! Account does not exist.";
                lblPayMsg.ForeColor = System.Drawing.Color.Red;
                ClientScript.RegisterStartupScript(this.GetType(), "PaymentAlert", "alert('Invalid Account Number! Account does not exist.');", true);
                return;
            }

            double balance = Convert.ToDouble(balStr);
            if (balance >= grandTotal)
            {
                // Reduceing balance using wcF
                wcfObj.UpdateBalance(accNo, grandTotal);
                double remainingBalance = balance - grandTotal;
                string selPdt = "select Prod_Id from Order_tab where User_Id=" + Session["regid"] + " and Ord_Status='order'";
                SqlDataReader dr = obj1.Fn_ExeReader(selPdt);
                List<int> lstpdtid = new List<int>();
                while (dr.Read())
                {
                    lstpdtid.Add(Convert.ToInt32(dr["Prod_Id"]));
                }

                // 5. Updating stats to paid
                foreach (int pid in lstpdtid)
                {
                    string upOrder = "update Order_tab set Ord_Status='paid' where User_Id=" + Session["regid"] + " and Ord_Status='order' and Prod_Id=" + pid + "";
                    obj1.Fn_ExecuteNonQuery(upOrder);

                    string selStock = "select Prod_Stock from Product_tab where Prod_Id=" + pid + "";
                    string oldStockStr = obj1.Fn_ExeScalar(selStock);
                    int oldstock = Convert.ToInt32(oldStockStr);
                    string selQty = "select Ord_Quantity from Order_tab where User_Id=" + Session["regid"] + " and Prod_Id=" + pid + " and Ord_Status='paid'";
                    string qtyStr = obj1.Fn_ExeScalar(selQty);
                    int quantity = Convert.ToInt32(qtyStr);
                    // Reducing stock
                    int newstock = oldstock - quantity;
                    string upStock = "update Product_tab set Prod_Stock=" + newstock + " where Prod_Id=" + pid + "";
                    obj1.Fn_ExecuteNonQuery(upStock);
                }

                string successMsg = "Payment of ₹" + grandTotal + " Successful! Remaining Balance: ₹" + remainingBalance;
                lblPayMsg.Text = successMsg;
                lblPayMsg.ForeColor = System.Drawing.Color.Green;
                // Alert box 
                string alertScript = "alert('Payment of ₹" + grandTotal + " Successful!\\n\\nRemaining Account Balance: ₹" + remainingBalance + "');";
                ClientScript.RegisterStartupScript(this.GetType(), "PaymentAlert", alertScript, true);
            }
            else
            {
                string failMsg = "Insufficient Balance in Account! Current Balance: ₹" + balance + ", Amount Required: ₹" + grandTotal;
                lblPayMsg.Text = failMsg;
                lblPayMsg.ForeColor = System.Drawing.Color.Red;

                string alertScript = "alert('Insufficient Balance in Account!\\n\\nCurrent Balance: ₹" + balance + "\\nAmount Required: ₹" + grandTotal + "');";
                ClientScript.RegisterStartupScript(this.GetType(), "PaymentAlert", alertScript, true);
            }
        }
    }
}
