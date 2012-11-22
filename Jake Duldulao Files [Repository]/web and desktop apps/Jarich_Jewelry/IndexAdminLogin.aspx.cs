using System;
using System.Collections;
using System.Collections.Generic;
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

public partial class IndexAdminLogin : System.Web.UI.Page
{
    string usersLogin = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Article1.DataBind();
        if (!this.IsPostBack)
            ViewState["LoginErrors"] = 0;
    }
    private bool YourValidationFunction(string UserName, string Password)
    {

        bool boolReturnValue = false;
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        SqlCommand command = new SqlCommand("SELECT * FROM ADMINISTRATOR WHERE A_UserName = '" + UserName + "'AND A_PAssword = '" + Password + "'", conn);
        SqlDataReader Dr;
        conn.Open();
        Dr = command.ExecuteReader();
        while (Dr.Read())
        {
            if ((UserName == Dr["A_UserName"].ToString()) & (Password == Dr["A_PAssword"].ToString()))
            {
                boolReturnValue = true;
                usersLogin = Dr[3].ToString() + ", " + Dr[4].ToString() + " " + Dr[5].ToString();
                Session["Admins"] = usersLogin.ToString();
            }
            Dr.Close();
            return boolReturnValue;
        }
        return boolReturnValue;
    }
    protected void UserLogin_Authenticate(object sender, AuthenticateEventArgs e)
    {
        Login log = Article1.ContentPlaceholder.Controls[0].FindControl("UserLogin") as Login;


        if (YourValidationFunction(log.UserName, log.Password))
        {
            // e.Authenticated = true;
            log.Visible = false;
            Response.Redirect("IndexAdminControlPanel.aspx?");
        }
        else
        {
            e.Authenticated = false;
        }
    }
    protected void UserLogin_LoginError(object sender, EventArgs e)
    {
        Login log = Article1.ContentPlaceholder.Controls[0].FindControl("UserLogin") as Login;

        if (ViewState["LoginErrors"] == null)
            ViewState["LoginErrors"] = 0;

        int ErrorCount = (int)ViewState["LoginErrors"] + 1;
        ViewState["LoginErrors"] = ErrorCount;

        if ((ErrorCount > 3) && (log.PasswordRecoveryUrl != string.Empty))
            Response.Redirect(log.PasswordRecoveryUrl);
    }
}