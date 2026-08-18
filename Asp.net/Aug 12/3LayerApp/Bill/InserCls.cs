using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Bill
{
    public class InserCls
    {
        public int Fn_Insert(string na,int ag,string addr,string ph,string una,string pw)
        {
            ConClas obj1 = new ConClas();
            string ins = "insert into Twolayer values('" + na + "','" + ag + "','" + addr + "','" + ph + "','" + una + "','" + pw + "')";
            int i = obj1.Fn_ExecuteNonQuery(ins);
            return i;
        }

    }
}
