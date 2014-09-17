using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forum_Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["forumcookie"] != null)
        {
            Response.Cookies["forumcookie"].Expires = DateTime.Now.AddDays(-1);
        }
        else
        {
            content.InnerHtml = "Her skulle du vist ikke have endt. Tryk <a href='Default.aspx'>her</a> for at vende tilbage til forsiden.";
        }
        Response.Redirect("Default.aspx");
    }
}