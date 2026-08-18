using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTwoLayer
{
    public partial class InsertDB : System.Web.UI.Page
    {
        ConnectionClass obj1 = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string str = "insert into Twolayer values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','"+path+"','"+TextBox5.Text+"','"+TextBox6.Text+"')";
            int i = obj1.Fn_ExecuteNonQuery(str);
            if (i == 1)
            {
                Label7.Text = "inserted";
            }
        }
    }
}