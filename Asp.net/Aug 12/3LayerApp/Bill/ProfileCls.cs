using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dal;

namespace Bill
{
    public class ProfileCls
    {
        ConClas obj1 = new ConClas();
        public SqlDataReader Fn_Getdata(int id)
        {
            string sel = "select name,age,address,photo from Twolayer where Id=" + id + "";
            SqlDataReader dr = obj1.Fn_ExeReader(sel);
            return dr;
        }

        public DataSet Fn_Getdata_Dataset(int id)
        {
            string str = "select name,age,address,photo from Twolayer where Id=" + id + "";
            DataSet ds = obj1.Fn_Adapter_Dataset(str);
            return ds;
        }

        public DataTable Fn_Getdata_Datatable(int id)
        {
            string str = "select name,age,address,photo from Twolayer where Id=" + id + "";
            DataTable ds = obj1.Fn_Adapter_Datatable(str);
            return ds;
        }
    }
}
