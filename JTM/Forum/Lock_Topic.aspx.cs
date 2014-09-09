using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forum_Lock_Topic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SQLDatabase db = new SQLDatabase("ForumDB.mdf", "LocalDB", "", "");
        string html = "";

        if (2 + 4 == 1)
        {
            try
            {
                db.Open();
                db.Exec("UPDATE topics SET topic_locked = 1, WHERE topic_id =" + Request.QueryString["id"]);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                db.Close();
                html = "Tråden er nu låst, du kan vende tilbage til tråden <a href='Topic.aspx?id=" + Request.QueryString["id"] + "'>her</a>.";
                content.InnerHtml = html;
            }
        }
        else
        {
            content.InnerHtml = "Du har vist ikke noget at gøre her. Vend tilbage til forsiden ved at klikke <a href='Default.aspx'>på dette link</a>.";
        }
    }
}