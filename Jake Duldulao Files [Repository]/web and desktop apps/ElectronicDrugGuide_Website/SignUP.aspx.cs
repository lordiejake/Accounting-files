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

public partial class SignUP : System.Web.UI.Page
{
    SqlConnection conn = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LinkButton2.Visible = false;
            if (Session["USERS"] != null)
            {
                LinkButton1.Text = "Sign out";
                lnkuser.Text = "WELCOME:   " + (string)(Session["USERS"]);
            }
            if (Session["USERS"] == null)
            {
                LinkButton1.Text = "Login";
            }
            
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            conn.Open();
            System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [tbl_UserClient] (userlname,userfname,usermname,userage,useraddress,usercontactnumber,useremailadd,usercodename,userpassword) Values (@userlname,@userfname,@usermname,@userage,@useraddress,@usercontactnumber,@useremailadd,@usercodename,@userpassword)", conn);
            // insertCommand.Parameters.Add("Pic", SqlDbType.Image, 0).Value = ConvertImageToByteArray(imag, System.Drawing.Imaging.ImageFormat.Jpeg);
            insertCommand.Parameters.Add(new SqlParameter("@userlname", TextBox1.Text));
            insertCommand.Parameters.Add(new SqlParameter("@userfname", TextBox2.Text));
            insertCommand.Parameters.Add(new SqlParameter("@usermname", TextBox3.Text));
            insertCommand.Parameters.Add(new SqlParameter("@userage", TextBox4.Text));
            insertCommand.Parameters.Add(new SqlParameter("@useraddress", TextBox5.Text));
            insertCommand.Parameters.Add(new SqlParameter("@usercontactnumber", TextBox6.Text));
            insertCommand.Parameters.Add(new SqlParameter("@useremailadd", TextBox7.Text));
            insertCommand.Parameters.Add(new SqlParameter("@usercodename", TextBox8.Text));
            insertCommand.Parameters.Add(new SqlParameter("@userpassword", TextBox9.Text));
            int queryResult = insertCommand.ExecuteNonQuery();
            if (queryResult == 1)
            {
                TextBox1.Text = null;
                TextBox2.Text = null;
                TextBox3.Text = null;
                TextBox4.Text = null;
                TextBox5.Text = null;
                TextBox6.Text = null;
                TextBox7.Text = null;
                TextBox8.Text = null;
                TextBox9.Text = null;
                LinkButton2.Visible = true;
                
            }

        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void LogInAdmin_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Userlogin.aspx?");
    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        if (LinkButton1.Text == "Sign out")
        {
            Session["USERS"] = null;
            Session["Administration"] = null;
            Response.Redirect("Illness.aspx?");

        }
        if (LinkButton1.Text == "Login")
        {
            Response.Redirect("Userlogin.aspx?");
        }
    }
}
