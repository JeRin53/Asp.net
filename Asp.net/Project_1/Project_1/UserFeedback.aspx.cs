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
    public partial class UserFeedback : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Display_Feedback();
            }
        }

        public void Display_Feedback()
        {
            if (Session["regid"] != null)
            {
                int uid = Convert.ToInt32(Session["regid"]);
                string sel = "SELECT dbo.Feedback_tab.Feed_Id, dbo.Feedback_tab.Prod_Id, dbo.Product_tab.Prod_Name, dbo.Feedback_tab.Feed_Msg, dbo.Feedback_tab.Feed_Date, dbo.Feedback_tab.Feed_Status, dbo.Feedback_tab.Reply_Msg FROM dbo.Feedback_tab LEFT JOIN dbo.Product_tab ON dbo.Feedback_tab.Prod_Id = dbo.Product_tab.Prod_Id WHERE dbo.Feedback_tab.User_Id = " + uid + " ORDER BY dbo.Feedback_tab.Feed_Id DESC";
                DataSet ds = obj1.Fn_Adapter_Dataset(sel);
                gvUserFeedback.DataSource = ds;
                gvUserFeedback.DataBind();
            }
            else
            {
                string sel = "SELECT dbo.Feedback_tab.Feed_Id, dbo.Feedback_tab.Prod_Id, dbo.Product_tab.Prod_Name, dbo.Feedback_tab.Feed_Msg, dbo.Feedback_tab.Feed_Date, dbo.Feedback_tab.Feed_Status, " +
                    "dbo.Feedback_tab.Reply_Msg FROM dbo.Feedback_tab LEFT JOIN dbo.Product_tab ON dbo.Feedback_tab.Prod_Id = dbo.Product_tab.Prod_Id ORDER BY dbo.Feedback_tab.Feed_Id DESC";
                DataSet ds = obj1.Fn_Adapter_Dataset(sel);
                gvUserFeedback.DataSource = ds;
                gvUserFeedback.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["regid"] == null)
            {
                Label1.Text = "Please login first to submit feedback.";
                Label1.ForeColor = System.Drawing.Color.Red;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please login first to submit feedback.');", true);
                return;
            }

            int uid = Convert.ToInt32(Session["regid"]);
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string ins = "insert into Feedback_tab values(" + uid + "," + TextBox1.Text.Trim() + ",'" + TextBox2.Text.Trim() + "','" + date + "',1,' ')";
            int i = obj1.Fn_ExecuteNonQuery(ins);
            if (i == 1)
            {
                Label1.Text = "Feedback submitted successfully!";
                Label1.ForeColor = System.Drawing.Color.Green;
                TextBox1.Text = "";
                TextBox2.Text = "";
                Display_Feedback();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Feedback submitted successfully!');", true);
            }
            else
            {
                Label1.Text = "Failed to submit feedback. Please try again.";
                Label1.ForeColor = System.Drawing.Color.Red;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Failed to submit feedback. Please try again.');", true);
            }
        }
    }
}