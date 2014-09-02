using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Produktside : System.Web.UI.Page
{
    SQLDatabase DB = new SQLDatabase("JTM.mdf", "LocalDB", "", "");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        string html = "<br />";
        html += "<table class='center'>";
        html += "<tr>";
        html += "<td><b>Produkt ID</b></td><td><b>Korn Type</b></td> <td><b>Mængde</b></td><td><b>pris per kg</b></td><td><b>Beskrivelse</b></td>";
        
        DB.Open();
        string[][] getData = DB.Query("SELECT * FROM productinfo");
        content12.InnerHtml = "";
        for (int i = 0; i < getData.Length; i++)
        {
            content12.InnerHtml += "<p>" + getData[i][1] + i + "</p>";

            html += "<tr>";
            html += "<td>" + getData[i][0] + "</td>" + "<td>" + getData[i][1] + "</td>" + "<td>" + getData[i][2] + "</td>" + "<td>" + getData[i][3] + "</td>" + "<td>" + getData[i][4] + "</td>";
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