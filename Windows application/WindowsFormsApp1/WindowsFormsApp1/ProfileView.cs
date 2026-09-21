using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProfileView : Form
    {
        ConClas obj1 = new ConClas();
        public ProfileView()
        {
            InitializeComponent();
        }

        private void ProfileView_Load(object sender, EventArgs e)
        {
            int getid = Convert.ToInt32(Form3.A.P1);

            string s = "select * from Win_Prof where Id=" + getid + "";
            SqlDataReader dr = obj1.Fn_ExeReader(s);
            while (dr.Read())
            {
                label16.Text = dr["name"].ToString();
                label15.Text = dr["address"].ToString();
                label12.Text = dr["Gender"].ToString();
                label13.Text = dr["state"].ToString();
                DateTime date = Convert.ToDateTime(dr["date"].ToString());
                label14.Text = date.ToShortDateString();
                label11.Text = dr["qualification"].ToString();
                label10.Text = dr["username"].ToString();
            }


            DataSet ds = obj1.Fn_Adapter_Dataset(s);
            dataGridView1.DataSource = ds.Tables[0];

            DataTable da = obj1.Fn_Adapter_Datatable(s);
            dataGridView2.DataSource = da;
        }
    }
}
