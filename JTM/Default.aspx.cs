using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    SQLDatabase DB = new SQLDatabase("JTM.mdf", "LocalDB", "", "");
    protected void Page_Load(object sender, EventArgs e)
    {
        DB.Open();
        string[][] profileArray = DB.Query("SELECT profile FROM profileinfo WHERE id=1");
        DB.Close();

        ProfileContent.InnerHtml = "<p>" + profileArray[0][0] + " TEST!" + "</p>";
    }
}