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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = richTextBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = comboBox1.SelectedItem.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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
            label7.Text = s;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sel = "";
            foreach(string s in checkedListBox1.CheckedItems)
            {
                sel = sel + s + ",";
            }
            label7.Text = sel;
        }
    }
}
