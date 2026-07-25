using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserRegistration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            string path = "~/Files/" +FileUpload1.FileName;
            Label24.Text = TextBox1.Text;
            Label25.Text = TextBox2.Text;
            Label26.Text = TextBox3.Text;
            Label27.Text = TextBox4.Text;
            Label28.Text = TextBox5.Text;
            Label29.Text = CheckBoxList1.SelectedItem.Text;
            Label30.Text = DropDownList1.SelectedItem.Text;
            Label31.Text = CheckBoxList1.SelectedItem.Text;
            FileUpload1.SaveAs(MapPath(path));
            Image1.ImageUrl = path;
            Label32.Text = TextBox6.Text;
            Label33.Text = TextBox8.Text;
        }
    }
}