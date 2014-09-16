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
        if (Request.Cookies["forumcookie"]["username"] != null)
        {
            SQLDatabase db = new SQLDatabase("ForumDB.mdf", "LocalDB", "", ""); 

            try
            {
                db.Open();
                db.Exec("INSERT INTO topics (topic_subject, topic_date, topic_cat, topic_by, topic_locked) VALUES('" + txtEmne.Text + "', GETDATE(), " + ddlSubforum.SelectedIndex + ", " + Request.Cookies["forumcookie"]["userid"] + ", 0)"); //TODO: De rigtige subforum-ID'er, skal hentes i dropdownlisten.
            }
            catch (Exception ex)
            {

            }
            finally
            {
                db.Close();
            }
        }
        else
        {
            content.InnerHtml = "Du skal være oprettet som bruger før du kan oprette en tråd.";
        }
    }
}