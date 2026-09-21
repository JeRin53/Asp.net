using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace Newapp
{
    public class Conclass
    {
        SqlConnection con;
        SqlCommand cmd;

        public Conclass()
        {
            con=new SqlConnection("@server=")
        }

        public Fn_ExecuteNonQuery(string sql)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}