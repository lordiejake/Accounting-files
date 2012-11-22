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

public partial class UserClients : System.Web.UI.Page
{
    double AdminID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["USERS"] != null)
            {
                LinkButton4.Text = "Sign out";
                lnkuser.Text = "WELCOME:   " + (string)(Session["USERS"]);
            }
            if (Session["USERS"] == null)
            {
                LinkButton4.Text = "Login";
            }

            if (Request.QueryString["AdminID"] != null)
                AdminID = double.Parse(Request.QueryString["AdminID"]);
            Label5.Text = AdminID.ToString(); 
            PostAllMembers();
        }
    }

    void PostAllMembers()
    {
        GridView5.DataSource = ClassDataManager.UserMembers();
        GridView5.DataBind();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddMedicine.aspx?AdminID=" + Label5.Text);
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddIllness.aspx?AdminID=" + Label5.Text);
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        if (LinkButton4.Text == "Sign out")
        {
            Session["USERS"] = null;
            Session["Administration"] = null;
            Response.Redirect("Illness.aspx?");

        }
        if (LinkButton4.Text == "Login")
        {
            Response.Redirect("Userlogin.aspx?");
        }
    }
}
