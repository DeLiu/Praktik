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
        if (!IsPostBack)
        {
            try
            {
                DB.Open();
                string[][] profileArray = DB.Query("SELECT profile FROM profileinfo WHERE Id=1");
                profilEditTextBox.Text = profileArray[0][0];

            }
            catch (Exception ex)
            {
                
            }
            finally
            {

                DB.Close();
            }
        }       
    }
    protected void Save_button_Click(object sender, EventArgs e)
    {
        string profileText = profilEditTextBox.Text;

        DB.Open();
        DB.Exec("UPDATE profileinfo SET profile='" + profileText + "' WHERE Id=1 IF @@ROWCOUNT=0 INSERT INTO profileinfo (Id, profile) VALUES (1, '" + profileText + "')");
        DB.Close();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "success", "alert('Profilen er nu gemt.'); setInterval(function(){location.href='EditProfilePage.aspx';},3000);", true);
    }
}