using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data.SqlClient;

public partial class Admin_Control_Panel_Index_Orders_Details_Panel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Load_GridData();
        }
    }

    void Load_GridData()
    {

        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        SqlCommand command = new SqlCommand("SELECT        ORDERGENERAL.Order_Num, ORDERGENERAL.Cust_Num, ORDERGENERAL.Order_Date, CUSTOMER.Cust_LName, CUSTOMER.Cust_FName,    CUSTOMER.Cust_MName, CUSTOMER.Cust_General_Balance, ORDERGENERAL.Total_Price, ORDERGENERAL.Cust_Order_CurrentBalance,   ORDERGENERAL.CreditCard, ORDERGENERAL.CreditCardNum   FROM            ORDERGENERAL INNER JOIN    CUSTOMER ON ORDERGENERAL.Cust_Num = CUSTOMER.Cust_Num ORDER BY ORDERGENERAL.Order_Date", conn);
        SqlDataAdapter daimages = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        daimages.Fill(dt);
        GridViewCustomers.DataSource = dt;
        GridViewCustomers.DataBind();
        GridViewCustomers.Attributes.Add("bordercolor", "black");
    }

    protected void GridViewCustomers_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            int cat = int.Parse(GridViewCustomers.DataKeys[index].Value.ToString());
            Session["OrderNum"] = cat.ToString();
            Response.Redirect("Admin-Control-Panel-Index-Orders-Details-with-specifications-Panel.aspx?Order_Num=" + int.Parse(GridViewCustomers.DataKeys[index].Value.ToString()));

        }
    }
}