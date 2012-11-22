using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Article1.DataBind();
        if (!IsPostBack)
        {
            if (Session["clients"] != null)
            {
                Panel PanelRegistration = Article1.ContentPlaceholder.Controls[0].FindControl("PanelRegistration") as Panel;
                Panel PanelLoginStatus = Article1.ContentPlaceholder.Controls[0].FindControl("PanelLoginStatus") as Panel;
                PanelLoginStatus.Visible = true;
                PanelRegistration.Visible = false;
            }
            else
            {
                Panel PanelRegistration = Article1.ContentPlaceholder.Controls[0].FindControl("PanelRegistration") as Panel;
                Panel PanelLoginStatus = Article1.ContentPlaceholder.Controls[0].FindControl("PanelLoginStatus") as Panel;
                PanelLoginStatus.Visible = false;
                PanelRegistration.Visible = true;
            }
        }
    }
}
