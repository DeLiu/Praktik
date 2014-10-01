using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forum_Create_Topic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnOpret_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["forumcookie"]["userlevel"] == "0")
        {
            SQLDatabase db = new SQLDatabase("ForumDB.mdf", "LocalDB", "", ""); 

            try
            {
                db.Open();
                db.Exec("INSERT INTO topics (topic_subject, topic_date, topic_cat, topic_by, topic_locked) VALUES('" + txtEmne.Text + "', GETDATE(), " + Request.QueryString["id"] + ", " + Request.Cookies["forumcookie"]["userid"] + ", 0)");
                //db.Exec("INSERT INTO posts (post_content, post_date, post_topic, post_by) VALUES ('" + txtContent.Text + "', GETDATE(), " + Request.QueryString["id"] + ", " + Request.Cookies["forumcookie"]["userid"]+")");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                db.Close();
                Response.Redirect("Category.aspx?id=" + Request.QueryString["id"]);
            }
        }
        else
        {
            content.InnerHtml = "Du skal være oprettet som bruger før du kan oprette en tråd.";
        }
    }
}