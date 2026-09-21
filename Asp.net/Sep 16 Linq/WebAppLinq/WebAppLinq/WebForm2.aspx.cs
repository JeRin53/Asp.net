using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppLinq
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Emp> Employees = new List<Emp>();
            Employees.Add(new Emp { Name = "Jerin", Age = 21, Salary = 20000 });
            Employees.Add(new Emp { Name = "Christo", Age = 22, Salary = 23000 });
            Employees.Add(new Emp { Name = "Jeese", Age = 23, Salary = 50000 });

            ///*var match = from n in Employees select n;
            //GridView1.DataSource = match;
            //GridView1.DataBind();

            //var match1 = from n in Employees where n.Age > 21 && n.Salary > 20000 select n;
            //GridView1.DataSource = match1;
            //GridView1.DataBind();

            //var match2 = from n in Employees select n.Name;
            //GridView1.DataSource = match2;
            //GridView1.DataBind();

            var match3 = from n in Employees select new { EmpName = n.Name, EmpAge = n.Age };
            GridView1.DataSource = match3;
            GridView1.DataBind();

            //var match4 = (from n in Employees select n.Age).Distinct();
            //GridView1.DataSource = match4;
            //GridView1.DataBind();

            /*var match5 = (from n in Employees select n.Age).Min();
            Response.Write(match5);*/

            /*var match6 = from n in Employees where TestEmployee(n) && n.Age>22 select n;
            GridView1.DataSource = match6;
            GridView1.DataBind();*/

            //var match7 = from n in Employees orderby n.Name ascending select n;
            //GridView1.DataSource = match7;
            //GridView1.DataBind();

            //var match8 = from n in Employees orderby n.Name descending select n;
            //GridView1.DataSource = match8;
            //GridView1.DataBind();
        }

        /*static bool TestEmployee(Emp n)
        {
            return n.Name.StartsWith("J");
        }*/
    }
}