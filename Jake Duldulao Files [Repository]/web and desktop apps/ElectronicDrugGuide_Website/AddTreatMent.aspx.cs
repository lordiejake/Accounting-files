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

public partial class AddTreatMent : System.Web.UI.Page
{
    double Proceed = 0;
    double tret = 0;

    SqlConnection conn = null;
    double illnessc;
    double AdminID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["USERS"] != null)
            {
                LinkButton6.Text = "Sign out";
                lnkuser.Text = "WELCOME:   " + (string)(Session["USERS"]);
            }
            if (Session["USERS"] == null)
            {
                LinkButton6.Text = "Login";
            }

            try
            {
                if (Request.QueryString["AdminID"] != null)
                  AdminID = double.Parse(Request.QueryString["AdminID"]);
                Label7.Text = AdminID.ToString(); 

                if (Request.QueryString["IllnessCode"] != null)
                    illnessc = double.Parse(Request.QueryString["IllnessCode"]);
                Label6.Text = illnessc.ToString();

                SampleIllness();
                PostTreatment();
                PostSymptoms();
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddMedicine.aspx?AdminID=" + Label7.Text);
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddIllness.aspx?AdminID=" + double.Parse(Label7.Text));
    }
    void SearchSymptomps() 
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_Symptoms WHERE Symptoms = '" + TextBox1.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Proceed = 0;
                    
                    Label10.Text  = dr[0].ToString();
                    //Response.Redirect("Administrator.aspx?AdminID=" + double.Parse(AdminStatus.Text));
                    LinkButton4.Visible = true;
                    LinkButton4.Text = "[" + TextBox1.Text + "]" + " is/are already on database. Proceed Anyway."; 
                }
            }
            else
            {
                Proceed = 1;
                Label10.Text = "Proceed";
                LinkButton4.Visible = false; 
                //AdminStatus.Text = "Check your Username/Password";
            }

        }
        catch (Exception)
        {
            //AdminStatus.Text = "failed to login";
        }
        
    }

    void SearchHomeRemedies()
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_Treatment WHERE TreatmentDescription = '" + TextBox2.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                   tret = 0;
                   LinkButton5.Visible = true;
                   LinkButton5.Text = "[" + TextBox2.Text + "]" + " is/are already on database. Proceed Anyway.";
                }
            }
            else
            {
                tret = 1;
                LinkButton5.Visible = false;
            }

        }
        catch (Exception)
        {
            //AdminStatus.Text = "failed to login";
        }

    }

    void J()
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT  TOP (1) SymptomsID  FROM  tbl_Symptoms ORDER BY SymptomsID DESC", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Label11.Text = dr[0].ToString();
                }
            }

        }
        catch (Exception)
        {
            throw;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SearchSymptomps();
        if (Proceed == 0)
        {
            
        }
        if (Proceed == 1)
        {
            try
            {
                ClassDataManager v = new ClassDataManager();
                v.Addsymptoms_NOW(TextBox1.Text, double.Parse(Label7.Text));
                J();
                addproceed2();
                Response.Redirect("AddTreatMent.aspx?AdminID=" + double.Parse(Label7.Text) + "&IllnessCode=" + int.Parse(Label6.Text));
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }

    void addproceed() 
    {
        try
        {
            ClassDataManager v = new ClassDataManager();
            v.Addsymptoms_Proceed(double.Parse(Label6.Text), double.Parse(Label10.Text), double.Parse(Label7.Text));
            LinkButton4.Visible = false;
        }
        catch (Exception)
        {

            throw;
        }
    }

    void addproceed2()
    {
        try
        {
            ClassDataManager v = new ClassDataManager();
            v.Addsymptoms_Proceed2(double.Parse(Label6.Text), double.Parse(Label11.Text), double.Parse(Label7.Text));
            LinkButton4.Visible = false;
        }
        catch (Exception)
        {

            throw;
        }
    }


    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        addproceed();
        Response.Redirect("AddTreatMent.aspx?AdminID=" + double.Parse(Label7.Text) + "&IllnessCode=" + int.Parse(Label6.Text));

    }

    void home() 
    {
        try
        {
            ClassDataManager v = new ClassDataManager();
            v.AddHomeRemedies(TextBox2.Text, double.Parse(Label6.Text), double.Parse(Label7.Text));
        }
        catch (Exception)
        {
            Response.Redirect("AddTreatMent.aspx?AdminID=" + double.Parse(Label7.Text) + "&IllnessCode=" + int.Parse(Label6.Text));
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            if (tret == 0)
            {
                SearchHomeRemedies();
            }
            if (tret == 1)
            {
                home();
                Response.Redirect("AddTreatMent.aspx?AdminID=" + double.Parse(Label7.Text) + "&IllnessCode=" + int.Parse(Label6.Text));
            }

        }
        catch (Exception)
        {
            Response.Redirect("AddTreatMent.aspx?AdminID=" + double.Parse(Label7.Text) + "&IllnessCode=" + int.Parse(Label6.Text));
        }
        
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        try
        {
            home();
            Response.Redirect("AddTreatMent.aspx?AdminID=" + double.Parse(Label7.Text) + "&IllnessCode=" + int.Parse(Label6.Text));
        }
        catch (Exception)
        {
            Response.Redirect("AddTreatMent.aspx?AdminID=" + double.Parse(Label7.Text) + "&IllnessCode=" + int.Parse(Label6.Text));
        }
       
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        if (LinkButton6.Text == "Sign out")
        {
            Session["USERS"] = null;
            Session["Administration"] = null;
            Response.Redirect("Illness.aspx?");

        }
        if (LinkButton6.Text == "Login")
        {
            Response.Redirect("Userlogin.aspx?");
        }
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("ManageDrugs.aspx?AdminID=" + double.Parse(Label7.Text) + "&IllnessCode=" + double.Parse(Label6.Text));
    }
}
