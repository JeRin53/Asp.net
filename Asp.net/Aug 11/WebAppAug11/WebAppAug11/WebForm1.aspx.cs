using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAug11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sum_service.ServiceClient obj = new sum_service.ServiceClient();
            //int s = obj.sum(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            int a = Convert.ToInt32(TextBox1.Text);
            int b = Convert.ToInt32(TextBox2.Text);
            int s = obj.sum(a, b);
            Label1.Text = s.ToString();

        }
    }
}