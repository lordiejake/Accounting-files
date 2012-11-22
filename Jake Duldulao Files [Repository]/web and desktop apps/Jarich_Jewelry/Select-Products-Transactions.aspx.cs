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

public partial class Select_Products_Transactions : System.Web.UI.Page
{
    double _GenderCategory = 0;
    double _CollectionsCategory = 0;
    double _TypesCategory = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Load_GridData();
        }

    }

    void Load_GridData()
    {
        string GenderCategory = (string)(Session["GeneralCategoryGenders"]);
        string CollectionsCategory = (string)(Session["CollectionsCat"]);
        string TypesCategory = (string)(Session["CategoryNum"]);
        _GenderCategory = double.Parse(GenderCategory.ToString());
        _CollectionsCategory = double.Parse(CollectionsCategory.ToString());
        _TypesCategory = double.Parse(TypesCategory.ToString());
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        SqlCommand command = new SqlCommand("SELECT        PRODUCT.Product_Num, PRODUCT.Product_Name, PRODUCT.Product_UpdatedDescription, PRODUCT.Product_UpdatedPrice, PRODUCT.Product_Status,   PRODUCT.Product_Image   FROM            CATEGORY INNER JOIN      PRODUCT ON CATEGORY.Category_Num = PRODUCT.Category_Num INNER JOIN    COLLECTIONCATEGORY ON PRODUCT.Collection_Num = COLLECTIONCATEGORY.Collection_Num INNER JOIN GENDERCATEGORY ON PRODUCT.GenderCategory_Num = GENDERCATEGORY.GenderCategory_Num    WHERE PRODUCT.GenderCategory_Num = '" + double.Parse(_GenderCategory.ToString())  + "'AND PRODUCT.Collection_Num = '" + double.Parse(_CollectionsCategory.ToString()) + "' AND CATEGORY.Category_Num = '" + double.Parse(_TypesCategory.ToString()) + "'", conn);
        SqlDataAdapter daimages = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        daimages.Fill(dt);
        GridImageRetrieve.DataSource = dt;
        GridImageRetrieve.DataBind();
        GridImageRetrieve.Attributes.Add("bordercolor", "black");
    }

    protected void GridImageRetrieve_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridImageRetrieve.PageIndex = e.NewPageIndex;
        Load_GridData();
        
    }
    protected void GridImageRetrieve_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            int cat = int.Parse(GridImageRetrieve.DataKeys[index].Value.ToString());
            Session["ProductNum"] = cat.ToString();
            Response.Redirect("Select-Products-Transactions-CkecksOut.aspx?Product_Num=" + int.Parse(GridImageRetrieve.DataKeys[index].Value.ToString()));

        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["clientID"] != null)
        {
            Response.Redirect("Select-Products-Transactions-CkecksOut-Shopping-Cart-Orders.aspx");
        }
        else
        {
            Response.Redirect("IndexLogin.aspx");
        }
    }
}