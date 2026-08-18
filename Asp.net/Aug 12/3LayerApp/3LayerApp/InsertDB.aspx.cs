using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bill;

namespace _3LayerApp
{
    public partial class InsertDB : System.Web.UI.Page
    {
        InserCls obj1 = new InserCls();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/Images/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            int i = obj1.Fn_Insert(TextBox1.Text, Convert.ToInt32(TextBox2.Text), TextBox3.Text, path, TextBox4.Text, TextBox5.Text);
            if (i == 1)
            {
                Label1.Text = "Inserted";
            }
        }
    }
}