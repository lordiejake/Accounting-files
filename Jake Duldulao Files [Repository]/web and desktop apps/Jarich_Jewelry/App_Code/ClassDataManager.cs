using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ClassDataManager
/// </summary>
public class ClassDataManager
{
    SqlConnection con = null;
	public ClassDataManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static List<ClassFields> Customer_Load()
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT * FROM CUSTOMER ORDER BY Cust_LName";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields fields = new ClassFields();
                            fields.Cust_Num = long.Parse(dr["Cust_Num"].ToString());
                            fields.Cust_LName = dr["Cust_LName"].ToString();
                            fields.Cust_FName = dr["Cust_FName"].ToString();
                            fields.Cust_MName = dr["Cust_MName"].ToString();
                            fields.Cust_AddressCountry = dr["Cust_AddressCountry"].ToString();
                            fields.Cust_AddressCity = dr["Cust_AddressCity"].ToString();
                            fields.Cust_AddressPostal = dr["Cust_AddressPostal"].ToString();
                            fields.Cust_AddressStreet = dr["Cust_AddressStreet"].ToString();
                            fields.Cust_Age = int.Parse(dr["Cust_Age"].ToString());
                            fields.Cust_EmailAddress = dr["Cust_EmailAddress"].ToString();
                            fields.Cust_General_Balance = dr["Cust_General_Balance"].ToString();
                            fields.Cust_username = dr["Cust_username"].ToString();
                            fields.Cust_Password = dr["Cust_Password"].ToString();
                            list.Add(fields);
                        }
                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> CatgoryLoad()
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT * FROM CATEGORY ORDER BY CategoryName";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields fields = new ClassFields();
                            fields.Category_Num = long.Parse(dr["Category_Num"].ToString());
                            fields.CategoryName = "[   " + dr["CategoryName"].ToString() + "   ]";
                            list.Add(fields);
                        }
                    }
                }
            }
        }
        return list;
    }

}