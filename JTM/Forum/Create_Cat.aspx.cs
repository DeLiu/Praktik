using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forum_Create_Cat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CreateSubBtn_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["forumcookie"] != null && subname != null && subdesc != null)
        {
            if (Request.Cookies["forumcookie"]["userlevel"] == "0")
            {
                SQLDatabase db = new SQLDatabase("ForumDB.mdf", "LocalDB", "", "");
                db.Open();
                db.Exec("INSERT INTO categories (cat_name, cat_description) VALUES ('" + subname.Value + "','"+subdesc.Value+"')");
                db.Close();
            }
            else
            {
                content.InnerHtml = "<p>Du skal være administrator for at oprette et nyt suforum</p>";
            }
            
        }
        Response.Redirect("Default.aspx");
    }
}