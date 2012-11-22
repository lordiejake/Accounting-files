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

public partial class Menu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["clients"] != null)
            {
                PanelLogout.Visible = true;
                PanelLogin.Visible = false;
                //Session["clients"] = null;
            }
            if (Session["clients"] == null)
            {
                PanelLogout.Visible = false;
                PanelLogin.Visible = true;
                //Session["clients"] = null;
            }
        }
    }
}
