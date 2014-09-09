using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forum_Create_Topic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnOpret_Click(object sender, EventArgs e)
    {
        SQLDatabase db = new SQLDatabase("ForumDB.mdf", "LocalDB", "", "");

        try
        {
            db.Open();
            db.Exec("INSERT INTO topics (topic_subject, topic_date, topic_cat, topic_by) VALUES('" + txtEmne.Text + "', GETDATE(), " + ddlSubforum.SelectedIndex + ", 1)"); //TODO: Userid fra cookie, de rigtige subforum-ID'er.
        }
        catch (Exception ex)
        {

        }
        finally
        {
            db.Close();
        }
    }
}