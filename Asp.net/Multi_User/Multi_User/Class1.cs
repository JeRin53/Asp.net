using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Multi_User
{
    public class Class1
    {
        SqlConnection con;
        SqlCommand cmd;
        
        public Class1()
        {
            con = new SqlConnection(@"server=JERINS-LEGION-7\SQLEXPRESS;database=MultiUserDB;Integrated security=true");
        }

        public int Fn_ExecuteNonQuery(string sqlquery)
        {
            
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public string Fn_ExeScalar(string sqlquery)
        {
            
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
    }
}