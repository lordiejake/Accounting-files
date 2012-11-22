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

/// <summary>
/// Summary description for ClassFields
/// </summary>
public class ClassFields
{
	public ClassFields()
	{
		//
		// TODO: Add constructor logic here
		//
	}

   
    public long Cust_Num { get; set; }
    public string Cust_LName { get; set; }
    public string Cust_FName { get; set; }
    public string Cust_MName { get; set; }
    public string Cust_AddressCountry { get; set; }
    public string Cust_AddressCity { get; set; }
    public string Cust_AddressPostal { get; set; }
    public string Cust_AddressStreet { get; set; }
    public int Cust_Age { get; set; }
    public string Cust_EmailAddress { get; set; }
    public string Cust_General_Balance { get; set; }
    public string Cust_username { get; set; }
    public string Cust_Password { get; set; }

    public long Category_Num { get; set; }
    public string CategoryName { get; set; }

    //public string UserBy { set; get; }

    //public string Names { set; get; }

    //public string Withtopics { set; get; }
}
