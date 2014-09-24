using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminRequiredContent_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Statistik sk = new Statistik();

        content.InnerHtml = "Du har pt. haft " + sk.GetIpCount() + " besøgende på dit website.";
    }
}