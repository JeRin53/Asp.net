using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        ConClas obj1 = new ConClas();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "select count(Id) from Win_prof where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
            int check = Convert.ToInt32(obj1.Fn_ExeScalar(str));
            if (check == 1)
            {
                string s1= "select Id from Win_prof where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
                string id = obj1.Fn_ExeScalar(s1);
                A.P1 = Convert.ToInt32(id);
                ProfileView ob = new ProfileView();
                ob.Show();
                this.Hide();
                label3.Text = "Logined";
                
                
            }
            else
            {
                label3.Text = "Invalid username pass";
            }

        }

        public static class A
        {
            public static int P1
            {
                set;get;
            }
        }
    }
}
