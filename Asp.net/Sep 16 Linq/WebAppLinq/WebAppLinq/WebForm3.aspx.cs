using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebAppLinq
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=JERINS-LEGION-7\SQLEXPRESS; database=LinqDB; Integrated security=true");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Employee",con);
            da.Fill(ds,"mp");

            /*var m = from n in ds.Tables["mp"].AsEnumerable() select n;
            GridView1.DataSource = m.AsDataView();
            GridView1.DataBind();*/

            var m1 = from n in ds.Tables[0].AsEnumerable() where n.Field<int>("Salary")>15000 select n;
            GridView1.DataSource = m1.AsDataView();
            GridView1.DataBind();

        }
    }
}