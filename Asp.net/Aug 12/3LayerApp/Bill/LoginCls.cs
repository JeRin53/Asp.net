using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Bill
{
    public class LoginCls
    {
        ConClas obj1 = new ConClas();
        public string GetCountId(string una, string pw)
        {
            
            string sel = "select Count(Id) from Twolayer where Username='"+una+"' and Password='"+pw+"'";
            string cid = obj1.Fn_ExeScalar(sel);
            return cid;
        }

        public string GetId(string una, string pw)
        {

            string sel = "select Id from Twolayer where Username='" + una + "' and Password='" + pw + "'";
            string id = obj1.Fn_ExeScalar(sel);
            return id;
        }
    }
}
