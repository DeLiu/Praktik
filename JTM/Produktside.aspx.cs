using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
public partial class Produktside : System.Web.UI.Page
{
    SQLDatabase DB = new SQLDatabase("JTM-Landbrug", "LocalDb", "admin", "1234");

    protected void Page_Load(object sender, EventArgs e)
    {
        DB.Open();
        string[][] getData = DB.Query("SELECT * FROM productinfo");
        for (int i = 0; i < getData.Length; i++)
        {
            content12.InnerHtml = "<p>" + getData[0][i] + "</p>";
        }
        DB.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}