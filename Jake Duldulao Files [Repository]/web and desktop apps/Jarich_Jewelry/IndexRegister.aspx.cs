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

public partial class IndexRegister : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Article1.DataBind();
        DropDownList drpDropDownCountry = Article1.ContentPlaceholder.Controls[0].FindControl("drpDropDownCountry") as DropDownList;
        drpDropDownCountry.Text = "--SelectCountry--";
        if (!IsPostBack)
        {
            if (Session["clients"] != null)
            {
                Panel PanelDirectToLogin = Article1.ContentPlaceholder.Controls[0].FindControl("PanelDirectToLogin") as Panel;
                PanelDirectToLogin.Visible = false;
                Panel PanelLogout = Article1.ContentPlaceholder.Controls[0].FindControl("PanelLogout") as Panel;
                PanelLogout.Visible = true;

                Panel PanelRegistrationForm = Article1.ContentPlaceholder.Controls[0].FindControl("PanelRegistrationForm") as Panel;
                PanelRegistrationForm.Visible = false;
                Panel PanelWarningForm = Article1.ContentPlaceholder.Controls[0].FindControl("PanelWarningForm") as Panel;
                PanelWarningForm.Visible = true;
            }
            else 
            {
                Panel PanelDirectToLogin = Article1.ContentPlaceholder.Controls[0].FindControl("PanelDirectToLogin") as Panel;
                PanelDirectToLogin.Visible = true;
                Panel PanelLogout = Article1.ContentPlaceholder.Controls[0].FindControl("PanelLogout") as Panel;
                PanelLogout.Visible = false;

                Panel PanelRegistrationForm = Article1.ContentPlaceholder.Controls[0].FindControl("PanelRegistrationForm") as Panel;
                PanelRegistrationForm.Visible = true;
                Panel PanelWarningForm = Article1.ContentPlaceholder.Controls[0].FindControl("PanelWarningForm") as Panel;
                PanelWarningForm.Visible = false;
            }
        }
    }
    void SearchUserNameDuplicate()
    {
        try
        {
            SqlConnection conn = ClassConnection.ConnectToServer();
            TextBox txtusername = Article1.ContentPlaceholder.Controls[0].FindControl("txtusername") as TextBox;
            SqlCommand command = new SqlCommand("SELECT Cust_username FROM CUSTOMER WHERE Cust_username = '" + txtusername.Text + "'", conn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Panel PanelProceedmessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelProceedmessage") as Panel;
                    Panel PanelErrormessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelErrormessage") as Panel;
                    Panel PanelWelcomemessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelWelcomemessage") as Panel;
                    Panel PanelCountryValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelCountryValidation") as Panel;
                    Panel PanelAgeValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelAgeValidation") as Panel;
                    Panel PanelUsernameDuplicateValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelUsernameDuplicateValidation") as Panel;
                    PanelWelcomemessage.Visible = false;
                    PanelProceedmessage.Visible = false;
                    PanelErrormessage.Visible = false;
                    PanelCountryValidation.Visible = false;
                    PanelAgeValidation.Visible = false;
                    PanelUsernameDuplicateValidation.Visible = true;
                }
            }
            else
            {
                Registration();
            }
        }
        catch (Exception)
        {

        }
    }

    public void Registration() 
    {
        try
        {
            TextBox txtlastname = Article1.ContentPlaceholder.Controls[0].FindControl("txtlastname") as TextBox;
            TextBox txtfirstname = Article1.ContentPlaceholder.Controls[0].FindControl("txtfirstname") as TextBox;
            TextBox txtmiddlename = Article1.ContentPlaceholder.Controls[0].FindControl("txtmiddlename") as TextBox;
            DropDownList drpDropDownCountry = Article1.ContentPlaceholder.Controls[0].FindControl("drpDropDownCountry") as DropDownList;
            TextBox txtcity = Article1.ContentPlaceholder.Controls[0].FindControl("txtcity") as TextBox;
            TextBox txtpostalcode = Article1.ContentPlaceholder.Controls[0].FindControl("txtpostalcode") as TextBox;
            TextBox txtstreet = Article1.ContentPlaceholder.Controls[0].FindControl("txtstreet") as TextBox;
            TextBox txtage = Article1.ContentPlaceholder.Controls[0].FindControl("txtage") as TextBox;
            TextBox txtemail = Article1.ContentPlaceholder.Controls[0].FindControl("txtemail") as TextBox;
            TextBox txtusername = Article1.ContentPlaceholder.Controls[0].FindControl("txtusername") as TextBox;
            TextBox txtpassword = Article1.ContentPlaceholder.Controls[0].FindControl("txtpassword") as TextBox;

            SqlConnection conn = ClassConnection.ConnectToServer();
            System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [CUSTOMER] (Status_Num,Cust_LName,Cust_FName,Cust_MName,Cust_AddressCountry,Cust_AddressCity,Cust_AddressPostal,Cust_AddressStreet,Cust_Age,Cust_EmailAddress,Cust_General_Balance,Cust_username,Cust_Password) Values (@Status_Num,@Cust_LName,@Cust_FName,@Cust_MName,@Cust_AddressCountry,@Cust_AddressCity,@Cust_AddressPostal,@Cust_AddressStreet,@Cust_Age,@Cust_EmailAddress,@Cust_General_Balance,@Cust_username,@Cust_Password)", conn);
            insertCommand.Parameters.Add(new SqlParameter("@Status_Num", "1"));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_LName", txtlastname.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_FName", txtfirstname.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_MName", txtmiddlename.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_AddressCountry", drpDropDownCountry.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_AddressCity", txtcity.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_AddressPostal", txtpostalcode.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_AddressStreet", txtstreet.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_Age", txtage.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_EmailAddress", txtemail.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_General_Balance", "0.0000"));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_username", txtusername.Text));
            insertCommand.Parameters.Add(new SqlParameter("@Cust_Password", txtpassword.Text));
            DropDownList drpDropDownCountry2 = Article1.ContentPlaceholder.Controls[0].FindControl("drpDropDownCountry") as DropDownList;


            if (drpDropDownCountry2.Text == "--SelectCountry--")
            {

                Panel PanelProceedmessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelProceedmessage") as Panel;
                Panel PanelErrormessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelErrormessage") as Panel;
                Panel PanelWelcomemessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelWelcomemessage") as Panel;
                Panel PanelCountryValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelCountryValidation") as Panel;
                Panel PanelAgeValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelAgeValidation") as Panel;
                Panel PanelUsernameDuplicateValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelUsernameDuplicateValidation") as Panel;
                PanelWelcomemessage.Visible = false;
                PanelProceedmessage.Visible = false;
                PanelErrormessage.Visible = false;
                PanelCountryValidation.Visible = true;
                PanelAgeValidation.Visible = false;
                PanelUsernameDuplicateValidation.Visible = false;
            }
            else
            {

                int queryResult = insertCommand.ExecuteNonQuery();
                if (queryResult == 1)
                {
                    Panel PanelProceedmessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelProceedmessage") as Panel;
                    Panel PanelErrormessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelErrormessage") as Panel;
                    Panel PanelWelcomemessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelWelcomemessage") as Panel;
                    Panel PanelCountryValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelCountryValidation") as Panel;
                    Panel PanelAgeValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelAgeValidation") as Panel;
                    Panel PanelUsernameDuplicateValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelUsernameDuplicateValidation") as Panel;
                    PanelUsernameDuplicateValidation.Visible = false;
                    PanelWelcomemessage.Visible = false;
                    PanelProceedmessage.Visible = true;
                    PanelErrormessage.Visible = false;
                    PanelCountryValidation.Visible = false;
                    PanelAgeValidation.Visible = false;
                    txtfirstname.Text = string.Empty;
                    txtlastname.Text = string.Empty;
                    txtmiddlename.Text = string.Empty;
                    txtpostalcode.Text = string.Empty;
                    txtstreet.Text = string.Empty;
                    txtemail.Text = string.Empty;
                    txtcity.Text = string.Empty;
                    txtage.Text = string.Empty;
                    txtusername.Text = string.Empty;
                    txtpassword.Text = string.Empty;
                }
            }
        }
        catch (Exception)
        {

            Panel PanelProceedmessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelProceedmessage") as Panel;
            Panel PanelErrormessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelErrormessage") as Panel;
            Panel PanelWelcomemessage = Article1.ContentPlaceholder.Controls[0].FindControl("PanelWelcomemessage") as Panel;
            Panel PanelCountryValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelCountryValidation") as Panel;
            Panel PanelAgeValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelAgeValidation") as Panel;
            Panel PanelUsernameDuplicateValidation = Article1.ContentPlaceholder.Controls[0].FindControl("PanelUsernameDuplicateValidation") as Panel;
            PanelUsernameDuplicateValidation.Visible = false;
            PanelWelcomemessage.Visible = false;
            PanelProceedmessage.Visible = false;
            PanelErrormessage.Visible = false;
            PanelCountryValidation.Visible = false;
            PanelAgeValidation.Visible = true;
        }
    }
    protected void BtnRegister_Click(object sender, EventArgs e)
    {
        SearchUserNameDuplicate();
    }
}