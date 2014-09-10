using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forum_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loginbt_Click(object sender, EventArgs e)
    {
        SQLDatabase Db = new SQLDatabase("ForumDB.mdf", "localDB", "", "");
        try
        {
            Db.Open();
           string[][] user = Db.Query("SELECT user_name,user_pass FROM Users Where user_name =" + username);
        }
        catch (Exception ex)
        {

        }
        finally
        {
            content.InnerHtml = html;
            db.Close();
        }
    }
}