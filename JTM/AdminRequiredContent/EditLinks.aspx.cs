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
        DB.Open();
        DB.Exec("INSERT INTO links (title, link) VALUES ('" + titleTextBox.Text + "', '" + linkTextBox.Text + "')");
        DB.Close();

        GridView1.DataBind();
    }
}