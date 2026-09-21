using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Admin : System.Web.UI.Page
    {
        ConClass obj1 = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins = "insert into Dept_tab values('" + TextBox1.Text + "')";
            int i = obj1.Fn_ExecuteNonQuery(ins);

            if (i == 1)
            {
                Label1.Text = "inserted";
            }
            else
            {
                Label1.Text = "unsucessfull";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = "SELECT dbo.[Doc_Reg-tab].Doctor_name, dbo.[Doc_Reg-tab].Doctor_age, dbo.Dept_tab.Dept_name, dbo.[Doc_Reg-tab].Doctor_photo  FROM dbo.Dept_tab INNER JOIN dbo.[Doc_Reg-tab] ON dbo.Dept_tab.Dept_Id = dbo.[Doc_Reg-tab].Dept_Id where dbo.Dept_tab.[Dept_name]= '"+ TextBox3.Text +"'";
            DataSet da = obj1.Fn_ExeDataAdapter(str);
            GridView1.DataSource = da;
            GridView1.DataBind();
            GridView1.Visible = true;
        }
    }
}