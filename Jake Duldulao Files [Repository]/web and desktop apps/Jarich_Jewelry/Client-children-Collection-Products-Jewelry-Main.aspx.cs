using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Client_children_Collection_Products_Jewelry_Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["GeneralCategoryGenders"] = "3";  // returs GenderCategory_Num for Kids
        }
    }
}