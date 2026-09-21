using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApp
{
    
    public class ConClass
    {
        SqlConnection con;
        SqlCommand cmd;

        public ConClass()
        {
            con = new SqlConnection(@"server=JERINS-LEGION-7\SQLEXPRESS;database=Exam;Integrated security=true");
        }

        public int Fn_ExecuteNonQuery(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public string Fn_ExeScalar(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }

        public DataSet Fn_ExeDataAdapter(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlquery,con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}