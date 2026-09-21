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
    public partial class Form2 : Form
    {
        ConClas obj1 = new ConClas();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "";
            if (radioButton1.Checked)
            {
                s = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                s = radioButton2.Text;
            }

            string d = "";
            foreach(string i in checkedListBox1.CheckedItems)
            {
                d = d + i + ",";
            }

            string newdt = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()).ToString("yyyy-MM-dd");
            string str = "insert into Win_prof values('" + textBox1.Text + "','" + richTextBox1.Text + "','" + s + "','" + comboBox1.SelectedItem.ToString() + "','" + newdt + "','" + d + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            int ins = obj1.Fn_ExecuteNonQuery(str);
            if (ins == 1)
            {
                label9.Text = "inserted";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
