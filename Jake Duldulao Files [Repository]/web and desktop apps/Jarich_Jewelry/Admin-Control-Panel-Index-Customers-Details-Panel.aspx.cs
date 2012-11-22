using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public partial class Admin_Control_Panel_Index_Customers_Details_Panel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Article2.DataBind();
        if (!IsPostBack)
        {
            PostDrugClass();
        }
    }

    void PostDrugClass()
    {
        GridView GridViewCustomers = Article2.ContentPlaceholder.Controls[0].FindControl("GridViewCustomers") as GridView;
        GridViewCustomers.DataSource = ClassDataManager.Customer_Load();
        GridViewCustomers.DataBind();
    }

}