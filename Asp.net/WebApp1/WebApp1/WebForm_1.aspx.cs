using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp1
{
    public partial class WebForm_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_display_Click(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            int num1 = Convert.ToInt32(txt1.Text);
            int num2 = Convert.ToInt32(txt2.Text);
            int sub = num1 - num2;

            Label1.Text = Convert.ToString(sub);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            int num1 = Convert.ToInt32(txt1.Text);
            int num2 = Convert.ToInt32(txt2.Text);
            int sum = num1 + num2;

            Label1.Text = Convert.ToString(sum);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            int num1 = Convert.ToInt32(txt1.Text);
            int num2 = Convert.ToInt32(txt2.Text);
            int div = num1 / num2;

            Label1.Text = Convert.ToString(div);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            int num1 = Convert.ToInt32(txt1.Text);
            int num2 = Convert.ToInt32(txt2.Text);
            int mul = num1 * num2;

            Label1.Text = Convert.ToString(mul);
        }
    }
}