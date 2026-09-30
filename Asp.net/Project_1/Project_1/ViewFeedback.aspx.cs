using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;

namespace Project_1
{
    public partial class ViewFeedback : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Display_Grid();
            }          
        }

        public void Display_Grid()
        {
            string sel = "SELECT dbo.Feedback_tab.Feed_Id,dbo.Feedback_tab.Prod_Id, dbo.User_tab.User_Name, dbo.User_tab.Email, dbo.Feedback_tab.Feed_Msg, dbo.Feedback_tab.Feed_Date " +
                "FROM dbo.Feedback_tab INNER JOIN dbo.User_tab ON dbo.Feedback_tab.User_Id = dbo.User_tab.User_Id where dbo.Feedback_tab.Feed_Status = 1";
            DataSet ds = obj1.Fn_Adapter_Dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            int feedId = Convert.ToInt32(GridView1.DataKeys[i].Values["Feed_Id"]);
            string mailId = GridView1.DataKeys[i].Values["Email"].ToString();

            Session["fid"] = feedId;
            TextBox1.Text = mailId;
            Panel1.Visible = true;
            Label1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select User_tab.User_Name from User_tab inner join Feedback_tab on User_tab.User_Id=Feedback_tab.User_Id where Feedback_tab.Feed_Status=1";
            string username = obj1.Fn_ExeScalar(sel);
            string reply = "update Feedback_tab set Reply_Msg='" + TextBox2.Text + "' , Feed_Status=0 where Feed_Id=" + Session["fid"] + " and Feed_Status=1";
            int i=obj1.Fn_ExecuteNonQuery(reply);
            if (i == 1)
            {
                
                SendEmail2("Jerin Joejoe", "jerinjoejoe.m@gmail.com", "zbws nipc ikdt atnt",username, TextBox1.Text, TextBox3.Text, TextBox2.Text);
                Label1.Text = "Reply sent and feedback updated sucessfully";
            }
            Panel1.Visible = false;
            Display_Grid();
        }

        public static void SendEmail2(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)

        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}