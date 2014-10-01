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
        if (Session["level"] != null)
        {
            if ((string)Session["level"] != "0")
            {
                Response.Redirect("~/Account/Login.aspx");
            }
        }
        else
            Response.Redirect("~/Account/Login.aspx");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Statistik sk = new Statistik();
        sk.Add(HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]);
    }

    protected void Log_out(object sender, LoginCancelEventArgs e)
    {
        
        //Context.GetOwinContext().Authentication.SignOut();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
    }
}
