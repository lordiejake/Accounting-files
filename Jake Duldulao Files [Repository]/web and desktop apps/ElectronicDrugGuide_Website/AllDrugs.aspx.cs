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

public partial class AllDrugs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["USERS"] != null)
            {
                LinkButton3.Text = "Sign out";
                lnkuser.Text = "WELCOME:   " + (string)(Session["USERS"]);
            }
            if (Session["USERS"] == null)
            {
                LinkButton3.Text = "Login";
            }

            PostMedicine();
        }
    }

    void PostMedicine()
    {
        GridView5.DataSource = ClassDataManager.AllDrugz();
        GridView5.DataBind();
    }

    void PostMedicineSearch()
    {
        GridView5.DataSource = ClassDataManager.AllDrugzSearch(TextBox1.Text);
        GridView5.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        PostMedicineSearch();
    }
    protected void LogInAdmin_Click(object sender, EventArgs e)
    {

    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void GridView5_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());

        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("DrugsSpecification.aspx?DrugCode=" + int.Parse(GridView5.DataKeys[index].Value.ToString()));
        }
    }
    protected void LinkButton3_Click1(object sender, EventArgs e)
    {

        if (LinkButton3.Text == "Sign out")
        {
            Session["USERS"] = null;
            Session["Administration"] = null;
            Response.Redirect("Illness.aspx?");

        }
        if (LinkButton3.Text == "Login")
        {
            Response.Redirect("Userlogin.aspx?");
        }
    }
}
