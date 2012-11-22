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

public partial class AddDrugSpecifications : System.Web.UI.Page
{
    double illnessc;
    double drugi;
    SqlConnection conn = null;
    double forn = 0;
    double sidem = 0;
    double drclass = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                
                    if (Session["USERS"] != null)
                    {
                        LinkButton7.Text = "Sign out";
                        lnkuser.Text = "WELCOME:   " + (string)(Session["USERS"]);
                    }
                    if (Session["USERS"] == null)
                    {
                        LinkButton7.Text = "Login";
                    }
                

                if (Request.QueryString["AdminID"] != null)
                    illnessc = double.Parse(Request.QueryString["AdminID"]);
                Label11.Text  = illnessc.ToString();

                if (Request.QueryString["DrugCode"] != null)
                    drugi = double.Parse(Request.QueryString["DrugCode"]);
                Label12.Text = drugi.ToString(); 

                PostEffects();
                Medicine();
                PostDoosage();
                PostDrugClass();
                Availableformz();

            }
            catch (Exception)
            {
                Response.Redirect("Illness.aspx?");
            }
        }
    }
    void PostEffects()
    {
        GridView3.DataSource = ClassDataManager.LoadSideEffects(drugi);
        GridView3.DataBind();
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

    void Availableformz()
    {
        GridView6.DataSource = ClassDataManager.FormsAvailable(drugi);
        GridView6.DataBind();
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


    void H() 
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT  TOP (1) FormsID  FROM  tbl_AvailableForms   ORDER BY FormsID DESC", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Label13.Text = dr[0].ToString();
                }
            }

        }
        catch (Exception)
        {
            throw;
        }
    }
    void I()
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT  TOP (1) SideEffectsID  FROM  tbl_SideEffects   ORDER BY SideEffectsID DESC", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Label14.Text = dr[0].ToString();
                }
            }

        }
        catch (Exception)
        {
            throw;
        }
    }

    void J()
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT  TOP (1) DosageID  FROM  tbl_Dosage ORDER BY DosageID DESC", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Label15.Text = dr[0].ToString();
                }
            }

        }
        catch (Exception)
        {
            throw;
        }
    }

    void Jkl()
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT  TOP (1) DrugclassID  FROM  tbl_DrugClass ORDER BY DrugclassID DESC", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Label19.Text = dr[0].ToString();
                }
            }

        }
        catch (Exception)
        {
            throw;
        }
    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddMedicine.aspx?AdminID=" + Label11.Text);
    }
    void SearchformsFirst()
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_AvailableForms WHERE AvailableForms = '" + TextBox3.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    forn = 0;
                    LinkButton4.Visible = true; 
                    Label16.Text = dr[0].ToString();
                    LinkButton4.Text = "[" + TextBox3.Text + "]" + " is already on database. Proceed anyway";  
                }
            }
            else
            {
                LinkButton4.Visible = false; 
                forn = 1;
                
            }

        }
        catch (Exception)
        {
            //AdminStatus.Text = "failed to login";
        }

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SearchformsFirst();
        if (forn == 0)
        {
            LinkButton4.Visible = true;
        }
        if (forn == 1)
        {


            try
            {
                double x = double.Parse(TextBox3.Text.Length.ToString());
                if (x > 0)
                {
                    ClassDataManager v = new ClassDataManager();
                    v.AddForms(TextBox3.Text, double.Parse(Label11.Text));
                    H();
                    v.AddFormsdrugs(double.Parse(Label13.Text), double.Parse(Label12.Text), double.Parse(Label11.Text));
                    Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));


                }

            }
            catch (Exception)
            {
                Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
            }
        }
       
    }
    void SearchSideEffectsfirst()
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_Sideeffects WHERE SideEffects = '" + "•"+TextBox2.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    sidem = 0;
                    Label17.Text = dr[0].ToString();
                    LinkButton5.Visible = true; 
                    LinkButton5.Text = "[" + TextBox2.Text + "]" + " is already on database. Proceed anyway";  
                }
            }
            else
            {
                LinkButton5.Visible = false;
                sidem = 1;

            }

        }
        catch (Exception)
        {
            //AdminStatus.Text = "failed to login";
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SearchSideEffectsfirst();
        if (sidem == 0)
        {
            
        }
        if (sidem == 1)
        {


            try
            {
                double x = double.Parse(TextBox2.Text.Length.ToString());
                if (x > 0)
                {
                    ClassDataManager v = new ClassDataManager();
                    v.AddDrugsideEFFECTS("•" + TextBox2.Text, double.Parse(Label11.Text));
                    I();
                    v.AdddrugsEffects_Transactions(double.Parse(Label14.Text), double.Parse(Label12.Text), double.Parse(Label11.Text));
                    Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
                }
            }
            catch (Exception)
            {
                Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
            }
        }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            double x = double.Parse(TextBox1.Text.Length.ToString());
            if (x > 0)
            {
                ClassDataManager v = new ClassDataManager();
                v.AddDrugDosage("•" + TextBox1.Text, double.Parse(Label11.Text));
                J();
                v.AdddrugsDosage_Transactions(double.Parse(Label15.Text), double.Parse(Label12.Text), double.Parse(Label11.Text));
                Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
            }
        }
        catch (Exception)
        {
            Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
        }
      
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddIllness.aspx?AdminID=" + double.Parse(Label11.Text));
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        try
        {
            double x = double.Parse(TextBox3.Text.Length.ToString());
            if (x > 0)
            {
                ClassDataManager v = new ClassDataManager();
                v.AddFormsdrugs(double.Parse(Label16.Text), double.Parse(Label12.Text), double.Parse(Label11.Text));
                Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));


            }

        }
        catch (Exception)
        {
            Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
        }
    }

    void ko() 
    {
        try
        {
            double x = double.Parse(TextBox2.Text.Length.ToString());
            if (x > 0)
            {
                ClassDataManager v = new ClassDataManager();
                v.AdddrugsEffects_Transactions(double.Parse(Label17.Text), double.Parse(Label12.Text), double.Parse(Label11.Text));
                Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
            }
        }
        catch (Exception)
        {
            Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
        }
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        try
        {
            ko();
            Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
        }
        catch (Exception)
        {
            Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
        }
    }
    void SearchDrugClassFirst()
    {
        try
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_DrugClass WHERE drugClass = '" + TextBox4.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    drclass = 0;
                    LinkButton6.Visible = true;
                    Label18.Text = dr[0].ToString();
                    LinkButton6.Text = "[" + TextBox4.Text + "]" + " is already on database. Proceed anyway";
                }
            }
            else
            {
                LinkButton6.Visible = false;
                drclass = 1;
            }

        }
        catch (Exception)
        {
            //AdminStatus.Text = "failed to login";
        }

    }

    void classx() 
    {
        try
        {
            double x = double.Parse(TextBox4.Text.Length.ToString());
            if (x > 0)
            {
                ClassDataManager v = new ClassDataManager();
                v.AdddrugsCLASSES_Transactions(double.Parse(Label18.Text), double.Parse(Label12.Text), double.Parse(Label11.Text));
                Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
            }
        }
        catch (Exception)
        {
            Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SearchDrugClassFirst();
        if (drclass==0)
        {
            
        }
        if (drclass==1)
        {

            try
            {
                double x = double.Parse(TextBox4.Text.Length.ToString());
                if (x > 0)
                {
                    ClassDataManager v = new ClassDataManager();
                    v.AddDRUG_CLASSNOW(TextBox4.Text, double.Parse(Label11.Text));
                    Jkl();
                    v.AdddrugsCLASSES_Transactions(double.Parse(Label19.Text), double.Parse(Label12.Text), double.Parse(Label11.Text));
                    Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
                }
            }
            catch (Exception)
            {
                Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
            }
        }
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        try
        {
            classx();
            Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
        }
        catch (Exception)
        {
            Response.Redirect("AddDrugSpecifications.aspx?AdminID=" + double.Parse(Label11.Text) + "&DrugCode=" + double.Parse(Label12.Text));
        }
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        if (LinkButton7.Text == "Sign out")
        {
            Session["USERS"] = null;
            Session["Administration"] = null;
            Response.Redirect("Illness.aspx?");

        }
        if (LinkButton7.Text == "Login")
        {
            Response.Redirect("Userlogin.aspx?");
        }
    }
}
