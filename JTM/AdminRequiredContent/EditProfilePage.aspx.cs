using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminRequiredContent_EditProfilePage : System.Web.UI.Page
{
    SQLDatabase DB = new SQLDatabase("JTM.mdf", "LocalDB", "", "");
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        DB.Open();
        DB.Exec("INSERT INTO profileinfo (Id, profile) VALUES (1, '" + profilEditTextBox.Text + "')");
        DB.Close();
        */

        DB.Open();
        string[][] profileArray = DB.Query("SELECT profile FROM profileinfo WHERE Id=1");

        profilEditTextBox.Text = profileArray[0][0].ToString();
        DB.Close();
    }
    protected void Save_button_Click(object sender, EventArgs e)
    {
        DB.Open();
        DB.Exec("UPDATE profileinfo SET profile='" + profilEditTextBox.Text + "' WHERE Id=1");
        DB.Close();
    }
}