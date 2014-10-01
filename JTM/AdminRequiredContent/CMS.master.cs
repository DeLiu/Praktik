using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminRequiredContent_CMS : System.Web.UI.MasterPage
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session.Count == 3)
        {
            loggedin.Visible = true;
            loggedout.Visible = false;
            if ((string)Session["level"] != "0")
            {
                Response.Redirect("~/Account/Login.aspx");
            }
        }
        else
        {
            loggedin.Visible = false;
            loggedout.Visible = true;
            Response.Redirect("~/Account/Login.aspx");
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Statistik sk = new Statistik();
        HttpBrowserCapabilities browser = Request.Browser;
        sk.Add(HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"], browser.Browser, browser.Version, browser.Platform);
    }

    protected void LogOut(object sender, EventArgs e)
    {
        loggedin.Visible = false;
        loggedout.Visible = true;
        Session.Abandon();
        Response.Redirect("~/Account/Login.aspx");
    }
}
