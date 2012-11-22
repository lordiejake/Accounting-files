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

public partial class Admin_Control_Panel_Index_Orders_Details_with_specifications_Panel : System.Web.UI.Page
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
        string sesionid = (string)(Session["OrderNum"]);
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        SqlCommand command = new SqlCommand("SELECT        PRODUCT.Product_Name, ORDER_ITEM.Product_Current_Price, ORDER_ITEM.Product_Order_Quantity, ORDER_ITEM.Percent_Deduction,   ORDER_ITEM.Total_Amount  FROM            ORDER_ITEM INNER JOIN   PRODUCT ON ORDER_ITEM.Product_Num = PRODUCT.Product_Num    WHERE  ORDER_ITEM.Order_Num = '" + sesionid.ToString() + "'", conn);
        SqlDataAdapter daimages = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        daimages.Fill(dt);
        GridViewCustomers.DataSource = dt;
        GridViewCustomers.DataBind();
        GridViewCustomers.Attributes.Add("bordercolor", "black");
    }
}