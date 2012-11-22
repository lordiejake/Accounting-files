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

public partial class DrugClasstoDrugs : System.Web.UI.Page
{
    double drugClassId;
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

             if (Request.QueryString["DrugClassID"] != null)
                 drugClassId = double.Parse(Request.QueryString["DrugClassID"]);
             Label4.Text = drugClassId.ToString();


             drug_byClasses();
        }
    }

    void drug_byClasses()
    {
        GridView5.DataSource = ClassDataManager.DrugClass_Medecina(drugClassId);
        GridView5.DataBind();
    }


    protected void GridView5_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());

        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("DrugClasstoDrugsInfo.aspx?DrugCode=" + int.Parse(GridView5.DataKeys[index].Value.ToString()) + "&DrugClassID=" + double.Parse(Label4.Text));
        }
    }
    protected void LogInAdmin_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("DrugClasses.aspx?");
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
