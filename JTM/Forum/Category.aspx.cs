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
            string[][] getCat = db.Query("SELECT cat_id, cat_name, cat_description FROM categories WHERE cat_id = " + Request.QueryString["id"]);
            string[][] getTop = db.Query("SELECT topic_id, topic_subject, topic_date, topic_cat FROM topics WHERE topic_cat =" + Request.QueryString["id"]);

            for (int i = 0; i < getCat.Length; i++)
            {
                html += "<h2>Tråde i " + getCat[i][1] + "-subforummet</h2>";
                if (Request.Cookies["forumcookie"]["userlevel"] == "0")
                {
                    html += "<h3><a class='item' href='Create_topic.aspx?id=" + getCat[i][0] + "'>Opret ny tråd</a>";
                }
            }

            html += "<table border='1'>";
            html += "<tr>";
            html += "<th>Tråd</th>";
            html += "<th>Skabt d. </th>";
            html += "</tr>";

            for (int i = 0; i < getTop.Length; i++)
            {
                html += "<tr>";
                html += "<td class='leftpart'>";
                html += "<h3><a href='Topic.aspx?id=" + getTop[i][0] + "'>" + getTop[i][1] + "</a>";
                if (Request.Cookies["forumcookie"] != null)
                {
                    if (Request.Cookies["forumcookie"]["userlevel"] == "0")
                    {
                        html += " <a class='item' href='Delete_Topic.aspx?id=" + getTop[i][0] + "'>Slet tråd</a>";
                        html += "<a class='item' href='Lock_Topic.aspx?id=" + getTop[i][0] + "'>Lås tråd</a>";
                    }
                    else
                    {
                        html += "</h3>";
                    }
                }
                html += "</td>";
                html += "<td class='rightpart'>";
                html += getTop[i][2];
                html += "</td>";
                html += "</tr>";
            }
        }
        catch (Exception ex)
        {

        }
        finally
        {
            content.InnerHtml = html;
            db.Close();
        }
    }
}