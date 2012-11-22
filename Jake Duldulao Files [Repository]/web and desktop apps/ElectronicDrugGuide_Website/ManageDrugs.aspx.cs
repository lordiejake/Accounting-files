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

public partial class ManageDrugs : System.Web.UI.Page
{
    double AdminID;
    double illnessc;
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

            try
            {
                if (Request.QueryString["AdminID"] != null)
                    AdminID = double.Parse(Request.QueryString["AdminID"]);
                Label8.Text = AdminID.ToString();

                if (Request.QueryString["IllnessCode"] != null)
                    illnessc = double.Parse(Request.QueryString["IllnessCode"]);
                Label9.Text = illnessc.ToString();

                SampleIllness();
                PostMedicine();
               
            }
            catch (Exception)
            {
                Response.Redirect("Illness.aspx?");
            }
        }
    }
    void PostMedicine()
    {
        GridView5.DataSource = ClassDataManager.LoadMedicines(illnessc);
        GridView5.DataBind();
    }

    void SampleIllness()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_Illness WHERE IllnessID = '" + illnessc + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    Label7.Text = "-->[" + dr[1].ToString() + "]";

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

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddMedicine.aspx?AdminID=" + Label8.Text);
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddIllness.aspx?AdminID=" + Label8.Text);
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
    protected void GridView5_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    void PostMedicineSearchings()
    {
        GridView5.DataSource = ClassDataManager.LoadMedicinesSearchings(double.Parse(Label9.Text), TextBox1.Text);
        GridView5.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        PostMedicineSearchings();
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserClients.aspx?AdminID=" + Label8.Text);
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddDrugstoillness.aspx?AdminID=" + double.Parse(Label8.Text) + "&IllnessCode=" + double.Parse(Label9.Text));
    }
}
