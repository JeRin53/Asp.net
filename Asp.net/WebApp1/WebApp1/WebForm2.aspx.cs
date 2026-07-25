using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Text;
            Label2.Text = DropDownList1.SelectedItem.Value;
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label1.Text = DropDownList1.SelectedItem.Text;
            Label2.Text = DropDownList1.SelectedItem.Value;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            Label4.Visible = true;
            Label3.Text = RadioButtonList1.SelectedItem.Text;
            Label4.Text = RadioButtonList1.SelectedItem.Value;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label5.Visible = true;
            Label6.Visible = true;
            Label5.Text = ListBox1.SelectedItem.Text;
            Label6.Text = ListBox1.SelectedItem.Value;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
            Label6.Visible = true;
            Label5.Text = ListBox1.SelectedItem.Text;
            Label6.Text = ListBox1.SelectedItem.Value;
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label7.Visible = true;
            Label8.Visible = true;
            string sel = " ";
            string txt = " ";
            for(int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    sel = sel + CheckBoxList1.Items[i].Value + ",";
                    txt = txt + CheckBoxList1.Items[i].Text + ",";
                }
            }
            Label7.Text = sel;
            Label8.Text = txt;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label7.Visible = true;
            Label8.Visible = true;
            string sel = " ";
            string txt = " ";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    sel = sel + CheckBoxList1.Items[i].Value + ",";
                    txt = txt + CheckBoxList1.Items[i].Text + ",";
                }
            }
            Label7.Text = sel;
            Label8.Text = txt;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            string path = "~/Files/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));
            Label10.Text = path;
            Image1.ImageUrl = path;
        }
    }
}