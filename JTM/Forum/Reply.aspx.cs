using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forum_Reply : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SQLDatabase db = new SQLDatabase("ForumDB.mdf", "LocalDB", "", "");
        string html = "";

        try
        {
            db.Open();
            db.Exec("INSERT INTO posts(post_content, post_date, post_by) VALUES ('" + Request.Form["reply-content"] + "', NOW(), " + Request.QueryString["id"] + ", " + "0");

        }
        catch (Exception ex)
        {
            html = "Dit indlæg kunne ikke gemmes. Prøv igen senere.";
        }
        finally
        {
            html += "Dit indlæg er gemt, se det <a href='Topic.aspx?id=" + Request.QueryString["id"] + "'>her</a>.";
            content.InnerHtml = html;
            db.Close();
        }
    }
}