using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forum_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SQLDatabase db = new SQLDatabase("ForumDB.mdf", "LocalDB", "", "");
        string html = "";

        try
        {
            db.Open();
            string[][] sql = db.Query("SELECT * FROM categories");

            html += "<table border='1'>";
            html += "<tr>";
            html += "<th>Subforum</th>";
            html += "</tr>";

            for (int i = 0; i < sql.Length; i++)
            {
                html += "<tr>";
                html += "<td class='leftpart'>";
                html += "<h3><a href='Category.aspx?id=" + sql[i][0] + "'>" + sql[i][1] + "</a></h3>" + sql[i][2];
                html += "</td>";
                html += "</tr>";
            }
        }
        catch (Exception ex)
        {
            html = "Trådene kunne ikke hentes";
        }
        finally
        {
            content.InnerHtml = html;
            db.Close();
        }
    }
}