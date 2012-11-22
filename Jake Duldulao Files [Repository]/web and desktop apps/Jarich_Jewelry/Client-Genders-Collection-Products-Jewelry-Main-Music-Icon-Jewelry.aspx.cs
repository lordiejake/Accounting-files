using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Client_children_Collection_Products_Jewelry_Main_Music_Icon_Jewelry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Article1.DataBind();
        Article2.DataBind();


        if (!IsPostBack)
        {
            Panel PanelMen = Article1.ContentPlaceholder.Controls[0].FindControl("PanelMen") as Panel;
            Panel PanelWomen = Article1.ContentPlaceholder.Controls[0].FindControl("PanelWomen") as Panel;
            Panel PanelKids = Article1.ContentPlaceholder.Controls[0].FindControl("PanelKids") as Panel;

            Session["CollectionsCat"] = "4";

            if (Session["GeneralCategoryGenders"] == "1")
            {
                PanelMen.Visible = true;
                PanelWomen.Visible = false;
                PanelKids.Visible = false;
            }
            if (Session["GeneralCategoryGenders"] == "2")
            {
                PanelMen.Visible = false;
                PanelWomen.Visible = true;
                PanelKids.Visible = false;
            }
            if (Session["GeneralCategoryGenders"] == "3")
            {
                PanelMen.Visible = false;
                PanelWomen.Visible = false;
                PanelKids.Visible = true;
            }
            PostCategory();
        }
    }

    void PostCategory()
    {
       // GridView GridViewCategory = Article2.ContentPlaceholder.Controls[0].FindControl("GridViewCategory") as GridView;
        GridViewCategory.DataSource = ClassDataManager.CatgoryLoad();
        GridViewCategory.DataBind();
    }
    protected void GridViewCategory_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            int cat = int.Parse(GridViewCategory.DataKeys[index].Value.ToString());
            Session["CategoryNum"] = cat.ToString();
            Response.Redirect("Select-Products-Transactions.aspx?Category_Num=" + int.Parse(GridViewCategory.DataKeys[index].Value.ToString()));

        }
    }
}