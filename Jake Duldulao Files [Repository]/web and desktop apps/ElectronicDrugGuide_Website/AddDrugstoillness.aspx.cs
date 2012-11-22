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


public partial class AddDrugstoillness : System.Web.UI.Page
{
    SqlConnection conn = null;
    double AdminID;
    double illnessc;
    double DRDI = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            LinkButton6.Visible = false; 
            try
            {
                if (Session["USERS"] != null)
                {
                    LinkButton4.Text = "Sign out";
                    lnkuser.Text  = "WELCOME:   " + (string)(Session["USERS"]);
                }
                if (Session["USERS"] == null)
                {
                    LinkButton4.Text = "Login";
                }

                if (Request.QueryString["AdminID"] != null)
                    AdminID = double.Parse(Request.QueryString["AdminID"]);
                Label6.Text = AdminID.ToString();

                if (Request.QueryString["IllnessCode"] != null)
                    illnessc = double.Parse(Request.QueryString["IllnessCode"]);
                Label5.Text = illnessc.ToString();

                SampleIllness();
                PostMedicine();
                //PostMedicine();

            }
            catch (Exception)
            {
                Response.Redirect("Illness.aspx?");
            }
            
        }
    }

    void PostMedicine()
    {
        GridView5.DataSource = ClassDataManager.AllDrugz();
        GridView5.DataBind();
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
            Response.Redirect("AdminLogin.aspx?");
        }

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {

    }
    protected void GridView5_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());

        if (e.CommandName.Equals("Select"))
        {
            LinkButton6.Visible = true;
            int dex = int.Parse(GridView5.DataKeys[index].Value.ToString());
           Label9.Text = dex.ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM tbl_DrugIllness WHERE DrugID = '" + dex + "' AND IllnessID = '" + double.Parse(Label5.Text) + "'", conn);
                conn.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        LinkButton6.Text = "This drug was already Recorded in this illness!";

                    }
                }
                else
                {
                    LinkButton6.Text = "[Click here] Save and Continue.";
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
    }
    void PostMedicineSearch()
    {
        GridView5.DataSource = ClassDataManager.AllDrugzSearch(TextBox1.Text);
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

                    Label8.Text = "[" + dr[1].ToString() + "]";

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

    protected void Button1_Click(object sender, EventArgs e)
    {
        PostMedicineSearch();
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        try
        {
            if (LinkButton6.Text == "[Click here] Save and Continue.")
            {
                ClassDataManager c = new ClassDataManager();
                c.AddDrugs_OILLNESS(double.Parse(Label9.Text), double.Parse(Label5.Text), double.Parse(Label6.Text));
                LinkButton6.Visible = false;
            }
            if (LinkButton6.Text != "[Click here] Save and Continue.")
            {
                LinkButton6.Visible = false;
            }
        }
        catch (Exception)
        {
            
            throw;
        }
        
    }
}
