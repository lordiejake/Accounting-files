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

public partial class AddIllness : System.Web.UI.Page
{
    double AdminID;
    double first = 0;
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

            if (Request.QueryString["AdminID"] != null)
                AdminID = double.Parse(Request.QueryString["AdminID"]);
            Label4.Text = AdminID.ToString(); 

            PostAllIllness();
        }
    }
    void SearchIllnessFirst()
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_illness WHERE IllnessName = '" + TextBox1.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    first = 0;
                    Label8.Visible = true; 
                    Label8.Text = TextBox1.Text + " is/are already on database";
                }
            }
            else
            {
                first = 1;
                Label8.Visible = false; 
            }

        }
        catch (Exception)
        {
            //AdminStatus.Text = "failed to login";
        }

    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        SearchIllnessFirst();
        if (first == 1)
        {
            try
            {
                ClassDataManager v = new ClassDataManager();
                v.AddIllness(TextBox1.Text, double.Parse(Label4.Text));
                Response.Redirect("AddIllness.aspx?AdminID=" + double.Parse(Label4.Text));
            }
            catch (Exception)
            {
                Response.Redirect("AddIllness.aspx?AdminID=" + double.Parse(Label4.Text));
            }
        }
        if (first == 0)
        {
            
        }
    }
    void PostAllIllnessSearching()
    {
        GridView2.DataSource = ClassDataManager.Illness_LoadSearching(TextBox4.Text);
        GridView2.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        PostAllIllnessSearching();
    }
    protected void GridView5_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddMedicine.aspx?AdminID=" + Label4.Text);
    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());

        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("AddTreatMent.aspx?AdminID=" + double.Parse(Label4.Text) + "&IllnessCode=" + int.Parse(GridView2.DataKeys[index].Value.ToString()));
        }

    }
    void PostAllIllness()
    {
        GridView2.DataSource = ClassDataManager.Illness_Load();
        GridView2.DataBind();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Administrator.aspx?AdminID=" + Label4.Text);
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
