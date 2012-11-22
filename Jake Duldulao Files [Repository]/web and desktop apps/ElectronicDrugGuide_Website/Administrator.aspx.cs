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


public partial class Administrator : System.Web.UI.Page
{
    double AdminID;
    SqlConnection conn = null;
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
                Response.Redirect("AdminLogin.aspx");
                LinkButton4.Text = "Login";
            }

            //ClassDataManager v = new ClassDataManager();
            if (Session["Ad"]!=null)
            {
                Label5.Text = "1"; 
            }
            if (Session["Ad"] == null)
            {
                Label5.Text = "0";
            }
            if (Request.QueryString["AdminID"] != null)
                 AdminID = double.Parse(Request.QueryString["AdminID"]);
            Label4.Text = AdminID.ToString(); 
            Admin();
        }
    }

    public void Admin() 
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_Administrator WHERE AdminID = '" + AdminID + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    LinkButton3.Text = dr[1].ToString() + " ," + dr[2].ToString() + " " + dr[3].ToString();
                }
            }
            else
            {
                LinkButton3.Text = "login";
            }

        }
        catch (Exception)
        {
            LinkButton3.Text = "login";
        }
        finally
        {
            conn.Close();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddMedicine.aspx?AdminID=" + Label4.Text);
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddIllness.aspx?AdminID=" + Label4.Text);
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
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserClients.aspx?AdminID=" + Label4.Text);
    }
}
