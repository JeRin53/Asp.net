using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class AdminReg : System.Web.UI.Page
    {
        Class1 obj1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // 1. Auto-calculate Reg_Id (Max + 1) from Login_tab
            string sel = "select Max(Reg_Id) from Login_tab";
            string regid = obj1.Fn_ExeScalar(sel);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            // 2. Insert into dbo.Admin_tab (Admin_Id, Email, Name)
            string ins = "insert into Admin_tab values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = obj1.Fn_ExecuteNonQuery(ins);
            if (i == 1)
            {
                // 3. Insert into dbo.Login_tab (Reg_Id, Username, Password, Log_Type = 'admin')
                string ins1 = "insert into Login_tab values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','admin')";
                int j = obj1.Fn_ExecuteNonQuery(ins1);
                if (i == 1 && j == 1)
                {
                    Label1.Text = "Sucessfully Registered";
                }
            }
            else
            {
                Label1.Text = "UnSucessfull";
            }
        }
    }
}