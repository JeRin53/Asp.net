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
	SqlConnection con = new SqlConnection(@"server=JERINS-LEGION-7\SQLEXPRESS;database=Project_1;Integrated security=true");
	

	public string CheckBalance(string accNo)
	{
		string sel = "select Balance_Amount from Account_tab where Acc_No='" + accNo + "'";
		SqlCommand cmd = new SqlCommand(sel,con);
		con.Open();
		string bal = "";
		SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
			bal=dr["Balance_Amount"].ToString();
        }
		con.Close();
		return bal;
	}

	public int UpdateBalance(string accNo, double amount)
	{
		string up = "update Account_tab set Balance_Amount = Balance_Amount - " + amount + " where Acc_No='" + accNo + "'";
		SqlCommand cmd = new SqlCommand(up,con);
		con.Open();
		int i = cmd.ExecuteNonQuery();
		con.Close();
		return i;
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
