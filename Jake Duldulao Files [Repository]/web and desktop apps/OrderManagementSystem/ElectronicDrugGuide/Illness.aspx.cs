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
    protected void LogInAdmin_Click(object sender, EventArgs e)
    {

    }

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
}
