using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppLinq
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataContext dc = new DataContext(@"data source=JERINS-LEGION-7\SQLEXPRESS; initial catalog=LinqDB; Integrated security=true");
                Table<Employee> employees = dc.GetTable<Employee>();

                GridView1.DataSource = employees;
                GridView1.DataBind();

                var m = from n in employees where n.Salary > 22000 select n;
                GridView1.DataSource = m;
                GridView1.DataBind();

                //select  job and name
                var m1 = from n in employees select new { Name = n.Name, Job = n.Job };
                GridView1.DataSource = m1;
                GridView1.DataBind();

                //select max value of id 
                var m3 = (from n in employees select n.Id).Max();
                Response.Write(m3);

                var m4 = from emp in employees select new { getid = emp.Id, getname = emp.Name };
                DropDownList1.DataSource = m4;
                DropDownList1.DataTextField = "getname";
                DropDownList1.DataValueField = "getid";
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source=JERINS-LEGION-7\SQLEXPRESS; initial catalog=LinqDB; Integrated security=true");
            Table<Employee> employees = dc.GetTable<Employee>();

            var m = from emp in employees where emp.Id == Convert.ToInt32(DropDownList1.SelectedItem.Value) select emp;
            foreach(Employee n in m)
            {
                TextBox1.Text = n.Id.ToString();
                TextBox2.Text = n.Name;
                TextBox3.Text = n.Job;
                TextBox4.Text = n.Salary.ToString();
            }

            GridView1.DataSource = m;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source=JERINS-LEGION-7\SQLEXPRESS; initial catalog=LinqDB; Integrated security=true");
            Table<Employee> employees = dc.GetTable<Employee>();

            Employee emp = new Employee { Id = Convert.ToInt32(TextBox1.Text), Name = TextBox2.Text, Job = TextBox3.Text, Salary = Convert.ToInt32(TextBox4.Text) };
            employees.InsertOnSubmit(emp);
            dc.SubmitChanges();

            GridView1.DataSource = employees;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source=JERINS-LEGION-7\SQLEXPRESS; initial catalog=LinqDB; Integrated security=true");
            Table<Employee> employees = dc.GetTable<Employee>();

            Employee emp = (from em in employees where em.Id == (Convert.ToInt32(DropDownList1.SelectedItem.Value))select em).FirstOrDefault();
            employees.DeleteOnSubmit(emp);
            dc.SubmitChanges();

            GridView1.DataSource = employees;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DataContext dc = new DataContext(@"data source=JERINS-LEGION-7\SQLEXPRESS; initial catalog=LinqDB; Integrated security=true");
            Table<Employee> employees = dc.GetTable<Employee>();

            Employee emp = (from em in employees where em.Id == (Convert.ToInt32(DropDownList1.SelectedItem.Value)) select em).FirstOrDefault();
            emp.Name = TextBox2.Text;
            emp.Job = TextBox3.Text;
            emp.Salary = Convert.ToInt32(TextBox4.Text);
            dc.SubmitChanges();

            GridView1.DataSource = employees;
            GridView1.DataBind();
        }
    }
}