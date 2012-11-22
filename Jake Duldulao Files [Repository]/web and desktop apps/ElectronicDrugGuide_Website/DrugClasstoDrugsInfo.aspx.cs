﻿using System;
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

public partial class DrugClasstoDrugsInfo : System.Web.UI.Page
{
   // double illnessc;
    double drugi;
    double drugClassId;
    SqlConnection conn = null;
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
            Label8.Text = drugClassId.ToString();

             if (Request.QueryString["DrugCode"] != null)
                 drugi = double.Parse(Request.QueryString["DrugCode"]);
             PostEffects();
             Availableformz();
             PostDrugClass();
             PostDoosage();
             Medicine();
             PostWarnings();
        }
    }
    protected void GridView3_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void LogInAdmin_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("DrugClasstoDrugs.aspx?DrugClassID=" + double.Parse(Label8.Text));
    }

    void PostEffects()
    {
        GridView3.DataSource = ClassDataManager.LoadSideEffects(drugi);
        GridView3.DataBind();
    }
    void PostWarnings()
    {
        GridView7.DataSource = ClassDataManager.Warnings(drugi);
        GridView7.DataBind();
    }

    void Availableformz()
    {
        GridView6.DataSource = ClassDataManager.FormsAvailable(drugi);
        GridView6.DataBind();
    }

    void PostDrugClass()
    {
        GridView5.DataSource = ClassDataManager.LoadDrugClass(drugi);
        GridView5.DataBind();
    }

    void PostDoosage()
    {
        GridView4.DataSource = ClassDataManager.LoadDosage(drugi);
        GridView4.DataBind();
    }


    void Medicine()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_Drugs WHERE DrugID = '" + drugi + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    lblViewMembers.Text = "-->[" + dr[1].ToString() + "]";

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
