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

public partial class Userlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label5.Visible = false;

            if (Session["USERS"] != null)
            {
                LinkButton3.Text = "Sign out";
                lnkuser.Text = "WELCOME:   " + (string)(Session["USERS"]);
            }
            if (Session["USERS"] == null)
            {
                LinkButton3.Text = "Login";
            }
        }
    }
    protected void LogInAdmin_Click(object sender, EventArgs e)
    {

    }
    void Login()
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_UserClient WHERE usercodename = '" + TextBox1.Text + "'AND userpassword= '" + TextBox2.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Label5.Visible = false;
                    Session["USERS"] = dr[1].ToString() + ", " + dr[2].ToString() + "  " + dr[3].ToString();
                    Response.Redirect("Illness.aspx?");
                }
            }
            else
            {
                Label5.Visible = true;
            }

        }
        catch (Exception)
        {
            throw;
            //AdminStatus.Text = "failed to login";
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Login();
    }
    protected void LinkButton3_Click1(object sender, EventArgs e)
    {
        if (LinkButton3.Text == "Sign out")
        {
            Session["USERS"] = null;
            Response.Redirect("Illness.aspx?");

        }
        if (LinkButton3.Text == "Login")
        {
            Response.Redirect("Userlogin.aspx?");
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUP.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUP.aspx?");
    }
    protected void LinkButton4_Click1(object sender, EventArgs e)
    {
        Response.Redirect("SignUP.aspx?");
    }
}
