using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace UserRegistration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=JERINS-LEGION-7\SQLEXPRESS;database=DbJuly31;Integrated security=true");
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
            Label29.Text = RadioButtonList1.SelectedItem.Text;
            Label30.Text = DropDownList1.SelectedItem.Text;
            Label31.Text = CheckBoxList2.SelectedItem.Text;
            FileUpload1.SaveAs(MapPath(path));
            Image1.ImageUrl = path;
            Label32.Text = TextBox6.Text;
            Label33.Text = TextBox8.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string p = "~/Phs/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string sel = "";
            for(int i = 0; i < CheckBoxList2.Items.Count; i++)
            {
                if (CheckBoxList2.Items[i].Selected)
                {
                    sel += CheckBoxList2.Items[i].Text + " " ;
                }
            }
            string strins = "insert into UserRegister values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "',"+TextBox4.Text+",'"+TextBox5.Text+"','"+RadioButtonList1.Text+"','"+DropDownList1.Text+"','"+sel+"','"+p+"','"+TextBox6.Text+"','"+TextBox7.Text+"')";
            SqlCommand cmd = new SqlCommand(strins,con);
            con.Open();
            int j = cmd.ExecuteNonQuery();
            con.Close();
            if (j == 1)
            {
                Label34.Text = "Registered";
            }
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            
            string sel = "select Count(Id) from UserRegister where username='" + TextBox6.Text + "'";
            SqlCommand cmd = new SqlCommand(sel, con);
            con.Open();
            string cid = cmd.ExecuteScalar().ToString();
            con.Close();
            //int id1=Convert.ToInt(cid);
            //if(id1>=1)
            if (cid=="1")
            {
                Label35.Visible=true;
                Label35.Text = "Username already taken";
            }
            else
            {
                Label35.Visible = false;
                
            }
            
        }
    }
}