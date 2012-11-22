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
using System.Text.RegularExpressions;

public partial class Admin_Control_Panel_Index_Promotions_Details_Panel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Article2.DataBind();
    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        SearchPromoDuplicate();
    }

    void SearchPromoDuplicate()
    {
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            TextBox TxtPromoName = Article2.ContentPlaceholder.Controls[0].FindControl("TxtPromoName") as TextBox;
            SqlCommand command = new SqlCommand("SELECT Promotion_Description FROM PROMOTION WHERE Promotion_Description = '" + TxtPromoName.Text + "'", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Panel CategoryExistsPanel = Article2.ContentPlaceholder.Controls[0].FindControl("CategoryExistsPanel") as Panel;
                    CategoryExistsPanel.Visible = true;
                    Panel CategoryAdded = Article2.ContentPlaceholder.Controls[0].FindControl("CategoryAdded") as Panel;
                    CategoryAdded.Visible = false;
                }
            }
            else
            {
                Panel CategoryExistsPanel = Article2.ContentPlaceholder.Controls[0].FindControl("CategoryExistsPanel") as Panel;
                CategoryExistsPanel.Visible = false;
                CreatePromo();
                Panel CategoryAdded = Article2.ContentPlaceholder.Controls[0].FindControl("CategoryAdded") as Panel;
                CategoryAdded.Visible = true;
            }
        }
        catch (Exception)
        {

        }
    }

    public void CreatePromo()
    {
        try
        {
            TextBox TxtPromoName = Article2.ContentPlaceholder.Controls[0].FindControl("TxtPromoName") as TextBox;
            TextBox TxtStartDate = Article2.ContentPlaceholder.Controls[0].FindControl("TxtStartDate") as TextBox;
            TextBox TxtEndDate = Article2.ContentPlaceholder.Controls[0].FindControl("TxtEndDate") as TextBox;

            SqlConnection conn = ClassConnection.ConnectToServer();
            System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [PROMOTION] (Promotion_Description,Promotion_StartDate,Promotion_EndDate) Values (@Promotion_Description,@Promotion_StartDate,@Promotion_EndDate)", conn);
            insertCommand.Parameters.Add(new SqlParameter("@Promotion_Description", TxtPromoName.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Promotion_StartDate", TxtStartDate.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Promotion_EndDate", TxtEndDate.Text));
            int queryResult = insertCommand.ExecuteNonQuery();
            if (queryResult == 1)
            {
                TxtPromoName.Text = string.Empty;
                TxtEndDate.Text = string.Empty;
                TxtStartDate.Text = string.Empty; 
            }
        }
        catch (Exception)
        {


        }
    }
}