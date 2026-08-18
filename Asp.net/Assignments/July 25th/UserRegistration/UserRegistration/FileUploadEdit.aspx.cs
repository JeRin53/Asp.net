using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace UserRegistration
{
    public partial class FileUploadEdit : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=JERINS-LEGION-7\SQLEXPRESS;database=DbJuly31;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Get_Grid();
            }
        }

        public void Get_Grid()
        {
            string str = "select * from UserRegister";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Get_Grid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Get_Grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtage = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            TextBox txtaddr = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];

            FileUpload fu = (FileUpload)GridView1.Rows[i].FindControl("FileUpload1");

            string path = " ";
            if (fu.HasFile)
            {
                path = "Phs/" + fu.FileName;
                fu.SaveAs(Server.MapPath(path));
            }
            string query = "update UserRegister set Age="+txtage.Text+",Address='"+txtaddr.Text+"',Photo='"+path+"' where id=" + id + "";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            GridView1.EditIndex = -1;
            Get_Grid();
        }
    }
}