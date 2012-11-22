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

public partial class Illness : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection conn = null;

        if (!IsPostBack)
        {
            if (Session["USERS"]!=null)
            {
                LinkButton3.Text = "Sign out";
                lnkuser.Text = "WELCOME:   " + (string)(Session["USERS"]);
            }
            if (Session["USERS"]==null)
            {
                LinkButton3.Text = "Login";
            }
            if (Session["Administration"]!=null)
            {
                LnkAdmin.Text = "Administrator[Online]";
            }
            if (Session["Administration"] == null)
            {
                LnkAdmin.Text = "Administrator";
            }

            PostAllIllness();
            countAllIllness();
        }
    }

    


    void countAllIllness()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(IllnessID) AS Expr1 FROM    tbl_Illness", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    lblViewMembers.Text = "[" + dr[0].ToString() + " Illness---]";

                }
            }

        }
        catch (Exception)
        {

        }
        finally
        {
            conn.Close();
        }
    }


    protected void LogName_TextChanged(object sender, EventArgs e)
    {

    }
    protected void pass_TextChanged(object sender, EventArgs e)
    {

    }
    protected void login_Click(object sender, EventArgs e)
    {

    }
    //protected void LogInAdmin_Click(object sender, EventArgs e)
    //{
    //    SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
    //    try
    //    {
    //        SqlCommand command = new SqlCommand("SELECT * FROM tbl_Administrator WHERE Adminuser ='" + txtadminusername.Text + "' AND AdminPassword ='" + txtadminpassword.Text + "'", conn);
    //        conn.Open();
    //        SqlDataReader dr = command.ExecuteReader();
    //        if (dr.HasRows)
    //        {
    //            while (dr.Read())
    //            {
    //                ClassDataManager c = new ClassDataManager();
    //                AdminStatus.Text = dr[0].ToString();
    //                Session["USERS"] = AdminStatus.Text;
    //                Response.Redirect("Administrator.aspx?AdminID=" + double.Parse(AdminStatus.Text));
    //            }
    //        }
    //        else
    //        {
    //            AdminStatus.Text = "Check your Username/Password";
    //        }

    //    }
    //    catch (Exception)
    //    {
    //        AdminStatus.Text  = "failed to login";
    //    }
    //    finally
    //    {
    //        conn.Close();
    //    }
    //}

    void PostAllIllness()
    {
        GridView2.DataSource = ClassDataManager.Illness_Load();
        GridView2.DataBind();
    }

    void PostAllIllnessSearching()
    {
        GridView2.DataSource = ClassDataManager.Illness_LoadSearching(TextBox1.Text);
        GridView2.DataBind();
    }


    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());

        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("Treatment.aspx?IllnessCode=" + int.Parse(GridView2.DataKeys[index].Value.ToString()));
        }

       


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        PostAllIllnessSearching();
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
    protected void LnkAdmin_Click(object sender, EventArgs e)
    {
        
        if (LnkAdmin.Text=="Administrator[Online]")
        {
            
        }
        if (LnkAdmin.Text!="Administrator[Online]")
        {
            Response.Redirect("AdminLogin.aspx?");
        }
    }
}
