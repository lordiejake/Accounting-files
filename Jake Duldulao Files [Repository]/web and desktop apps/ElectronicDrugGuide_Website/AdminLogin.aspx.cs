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

public partial class AdminLogin : System.Web.UI.Page
{
    SqlConnection conn = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["USERS"] != null)
            {
                LinkButton1.Text = "Sign out";
                lnkuser.Text = "WELCOME:   " + (string)(Session["USERS"]);
            }
            if (Session["USERS"] == null)
            {
                LinkButton1.Text = "Login";
            }   
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (LinkButton1.Text == "Sign out")
        {
            Session["USERS"] = null;
            Session["Administration"] = null;
            Response.Redirect("Illness.aspx?");

        }
        if (LinkButton1.Text == "Login")
        {
            Response.Redirect("Userlogin.aspx?");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_Administrator WHERE Adminuser ='" + TextBox1.Text + "' AND AdminPassword ='" + TextBox2.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Label6.Text = dr[1].ToString() + ", " + dr[2].ToString() + " " + dr[3].ToString() + "(Administrator)";
                    ClassDataManager c = new ClassDataManager();
                    Label5.Text = dr[0].ToString();
                    Session["USERS"] = Label6.Text;
                    Session["Administration"] = Label5.Text;
                    Response.Redirect("Administrator.aspx?AdminID=" + double.Parse(Label5.Text));
                }
            }
            else
            {
                //Label5.Text.Text = "Check your Username/Password";
            }

        }
        catch (Exception)
        {
            //AdminStatus.Text = "failed to login";
        }
        finally
        {
            conn.Close();
        }
    }
}
