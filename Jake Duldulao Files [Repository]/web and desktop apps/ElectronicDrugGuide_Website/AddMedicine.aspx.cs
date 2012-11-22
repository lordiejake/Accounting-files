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

public partial class AddMedicine : System.Web.UI.Page
{
    double AdminID;
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

            if (Request.QueryString["AdminID"] != null)
                AdminID = double.Parse(Request.QueryString["AdminID"]);
            Label6.Text = AdminID.ToString(); 
            PostMedicine();
        }
    }

    void PostMedicine()
    {
        GridView5.DataSource = ClassDataManager.AllDrugz();
        GridView5.DataBind();
    }
    protected void GridView5_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());

        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + Label6.Text + "&DrugCode=" + int.Parse(GridView5.DataKeys[index].Value.ToString()));
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Administrator.aspx?AdminID=" + double.Parse(Label6.Text));
    }

    void PostMedicineSearch()
    {
        GridView5.DataSource = ClassDataManager.AllDrugzSearch(TextBox4.Text);
        GridView5.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        PostMedicineSearch();
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {

        try
        {
            ClassDataManager v = new ClassDataManager();
            v.AddMedicine(TextBox1.Text, TextBox2.Text, TextBox3.Text, double.Parse(Label6.Text));
            Response.Redirect("AddMedicine.aspx?AdminID=" + double.Parse(Label6.Text));
            //Response.Redirect("AddMedicine.aspx?AdminID=" + double.Parse(Label6.Text));

        }
        catch (Exception)
        {
            Response.Redirect("AddMedicine.aspx?AdminID=" + double.Parse(Label6.Text));
        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddIllness.aspx?AdminID=" + double.Parse(Label6.Text));
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
