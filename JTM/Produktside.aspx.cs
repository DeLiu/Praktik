using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
public partial class Produktside : System.Web.UI.Page
{
    SQLDatabase DB = new SQLDatabase("JTM.mdf", "LocalDB", "", "");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        string html = "<br />";
        html += "<table border='1px'>";
        html += "<tr>";
        html += "<td><b>Korntype</b></td><td><b>ID</b></td>";

        DB.Open();
        string[][] getData = DB.Query("SELECT * FROM productinfo");
        content12.InnerHtml = "";
        for (int i = 0; i < getData.Length; i++)
        {
            html += "<tr>";
            html += "<td>" + getData[i][1] + "</td>" + "<td>" + i + "</td>";
            html += "</tr>";           
        }
        DB.Close();

        html += "</table>";
        content12.InnerHtml = html;
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}