using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multi_User
{
    public partial class AdminReg : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select Max(Reg_Id) from Login_tab";
            string maxrefid = obj1.Fn_ExeScalar(sel);
            int reg_id = 0;
            if (maxrefid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(maxrefid);
                reg_id = newregid + 1;
            }

            string ins = "insert into Admin_Reg values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = obj1.Fn_ExecuteNonQuery(ins);
            if (i == 1)
            {
                string ins1 = "insert into Login_tab values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','admin','active')";
                int j = obj1.Fn_ExecuteNonQuery(ins1);
                if (i == 1 && j == 1)
                {
                    Label5.Text = "Sucessfully Registered";
                }
            }
            else
            {
                Label5.Text = "UnSucessfull";
            }
        }
    }
}