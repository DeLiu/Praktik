using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forum_Topic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SQLDatabase db = new SQLDatabase("ForumDB.mdf", "LocalDB", "", "");
        string html = "";
        
        try
        {
            db.Open();
            string[][] getTop = db.Query("SELECT * topic_id, topic_subject FROM topics WHERE topics.topic_id = " + Request.QueryString["id"]);
            string[][] getPos = db.Query("SELECT posts.post_topic, posts.post_content, posts.post_date, posts.post_by, posts.post_id, users.user_id, users.user_name FROM posts LEFT JOIN users ON posts.post_by = Users.user_id WHERE posts.post_topic =" + Request.QueryString["id"]);

            for (int i = 0; i < getTop.Length; i++)
            {
                html += "<h2>Indlæg i ′" + getTop[i][1] + "′</h2>";
            }

            html += "<table border='1px'>";

            for (int i = 0; i < getPos.Length; i++)
            {
                html += "<tr>";
                html += "<th>Skrevet af: " + getPos[i][6] + " d. " + getPos[i][2];
                if (Request.Cookies["forumcookie"] != null)
                {
                    if (Request.Cookies["forumcookie"]["userlevel"] == "0")
                    {
                        html += " <a class='item' href='Delete_Reply.aspx?id=" + getPos[i][4] + "'>Slet indlæg</a>";
                    }
                    else
                    {
                        html += "</th>";
                    }
                }
                html += "</tr>";
                html += "<tr>";
                html += "<td class='leftpart'>";
                html += getPos[i][1];
                html += "</td>";
                html += "</tr>";
            }
        }
        catch (Exception ex)
        {
            html = "Fejlede under hentning af indlæg.";
        }
        finally
        {
            string[][] getLocked = db.Query("SELECT topic_locked FROM topics WHERE topic_id = " + Request.QueryString["id"]);
            html +=  "</table>";
			html +=  "<hr>";

            for (int i = 0; i < getLocked.Length; i++)
            {
                if (getLocked[i][0] == "1")
                {
                    Button1.Enabled = false;
                    html += "<p style='color:red'>Denne tråd er blevet lukket af en administrator. Det er ikke længere muligt at oprette indlæg i denne.</p>";
                }
            }
            if (Request.Cookies["forumcookie"] == null)
            {
                reply.Visible = false;
                Button1.Visible = false;
                html += "<a class='item' href=Login.aspx>Log ind for at oprette et indlæg</a> ";
            }
            content.InnerHtml = html;
        }
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Reply"] = reply.Value;
        Response.Redirect("reply.aspx?id=" + Request.QueryString["id"], false);
        
    }
}