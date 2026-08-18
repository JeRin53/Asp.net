using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	SqlConnection con = new SqlConnection(@"server=JERINS-LEGION-7\SQLEXPRESS;database=Aug12;integrated security=true");

	public string checkbalance(string acno)
    {
		string str = "select Acc_Bal from Acc_tab where Acc_No=" + acno + "";
		SqlCommand cmd = new SqlCommand(str, con);
		con.Open();
		string Bal = "";
		SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
			Bal = dr["Acc_Bal"].ToString();
        }
		con.Close();
		return Bal;
    }
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
