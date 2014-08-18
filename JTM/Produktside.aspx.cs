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
        DB.Open();
        string[][] getData = DB.Query("SELECT * FROM productinfo");
        content12.InnerHtml = "";
        for (int i = 0; i < getData.Length; i++)
        {
              content12.InnerHtml += "<p>" + getData[i][1] + i + "</p>";  
                    
        }
        DB.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}