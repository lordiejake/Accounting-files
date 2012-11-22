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
public partial class Treatment : System.Web.UI.Page
{
    double illnessc;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {

            
             try
             {
                 if (Request.QueryString["IllnessCode"] != null)
                 illnessc = double.Parse(Request.QueryString["IllnessCode"]);
                 AdminStatus.Text = illnessc.ToString();

                 SampleIllness();
                 PostTreatment();
                 PostSymptoms();
                 PostMedicine();
             }
             catch (Exception)
             {
                 Response.Redirect("Illness.aspx?");
             }

             try
             {
                 if (double.Parse(AdminStatus.Text) == 0)
                 {
                     Response.Redirect("Illness.aspx?");
                 }

             }
             catch (Exception)
             {
                 Response.Redirect("Illness.aspx?");
             }
             
        }

    }

    void PostTreatment()
    {
        GridView4.DataSource = ClassDataManager.LoadTreatments(illnessc);
        GridView4.DataBind();
    }

    void PostSymptoms()
    {
        GridView3.DataSource = ClassDataManager.LoadSymptoms(illnessc);
        GridView3.DataBind();
    }

    void PostMedicine()
    {
        GridView5.DataSource = ClassDataManager.LoadMedicines(illnessc);
        GridView5.DataBind();
    }

    void PostMedicineSearchings()
    {
        GridView5.DataSource = ClassDataManager.LoadMedicinesSearchings(double.Parse(AdminStatus.Text),TextBox1.Text);
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

                    lblViewMembers.Text =  "-->[" + dr[1].ToString() + "]";

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

    protected void LogInAdmin_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
            Response.Redirect("Illness.aspx?");
    }
    protected void GridView5_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("DosageSideEffects.aspx?IllnessCode=" + AdminStatus.Text + "&DrugCode=" + int.Parse(GridView5.DataKeys[index].Value.ToString()));
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        PostMedicineSearchings();
    }
}
