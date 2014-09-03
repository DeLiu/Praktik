using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminRequiredContent_EditLinks : System.Web.UI.Page
{
    SQLDatabase DB = new SQLDatabase("JTM.mdf", "LocalDB", "", "");
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void add_button_Click(object sender, EventArgs e)
    {
        string urlstring = linkTextBox.Text;

        DB.Open();
        DB.Exec("INSERT INTO links (title, link) VALUES ('" + titleTextBox.Text + "', '" + linkTextBox.Text + "')");
        //content12.InnerHtml += "<p>" + getData[i][1] + i + "</p>";
        DB.Close();

        GridView1.DataBind();

        //listedLinks.InnerHtml = "<li><asp:HyperLink NavigateUrl='http://tv2.dk'>"+ titleTextBox.Text +"</asp:HyperLink></li>";
    }
}