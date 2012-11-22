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

public partial class Admin_Control_Panel_IndexProductsCategoryPanel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Article2.DataBind();
    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        SearchUserNameDuplicate();
    }

    void SearchUserNameDuplicate()
    {
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            TextBox TxtCategoryName = Article2.ContentPlaceholder.Controls[0].FindControl("TxtCategoryName") as TextBox;
            SqlCommand command = new SqlCommand("SELECT CategoryName FROM CATEGORY WHERE CategoryName = '" + TxtCategoryName.Text + "'", conn);
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
                CreateCategory();
                Panel CategoryAdded = Article2.ContentPlaceholder.Controls[0].FindControl("CategoryAdded") as Panel;
                CategoryAdded.Visible = true; 
            }
        }
        catch (Exception)
        {

        }
    }
    public void CreateCategory()
    {
        try
        {
            TextBox TxtCategoryName = Article2.ContentPlaceholder.Controls[0].FindControl("TxtCategoryName") as TextBox;

            SqlConnection conn = ClassConnection.ConnectToServer();
            System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [CATEGORY] (CategoryName) Values (@CategoryName)", conn);
            insertCommand.Parameters.Add(new SqlParameter("@CategoryName", TxtCategoryName.Text));
            int queryResult = insertCommand.ExecuteNonQuery();
            if (queryResult == 1)
            {
                TxtCategoryName.Text = string.Empty;
            }                
        }
        catch (Exception)
        {

           
        }
    }
}