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
}
