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

            html += "<table border='1px'>";

            for (int i = 0; i < getTop.Length; i++)
            {
                html += "<h2>Indlæg i ′" + getTop[i][1] + "′</h2>";
            }

            for (int i = 0; i < getPos.Length; i++)
            {
                html += "<tr>";
                html += "<th>Skrevet af: " + getPos[i][6] + " d. " + getPos[i][2];
                if (2 + 2 == 3)
                {
                    html += "<form method='post' action='Delete_Reply.aspx?id=" + getPos[i][4] + "'>";
                    html += "<input type='submit' value='Slet indlæg' />";
                    html += "</form>";
                    html += "</th>";
                }
                else
                {
                    html += "</th>";
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
            html = "Fejlede under hetning af indlæg.";
        }
        finally
        {
            html +=  "</table>";
			html +=  "<hr>";
			html +=  "<form method='post' runat='server' action='Reply.aspx?id=" + Request.QueryString["id"] + "'>";
			html +=  "<textarea name='reply-content'></textarea>";
			html +=  "<br />";
			html +=  "<input type='submit' value='Indsend indlæg' />";
            html +=  "</form>";
            content.InnerHtml = html;
        }
    }
}