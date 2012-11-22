using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultMenuProducts : System.Web.UI.UserControl
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