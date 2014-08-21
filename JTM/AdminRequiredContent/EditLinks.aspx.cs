using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminRequiredContent_EditLinks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void add_button_Click(object sender, EventArgs e)
    {
        string urlstring = linkTextBox.Text;


        listedLinks.InnerHtml = "<li><asp:HyperLink NavigateUrl='http://tv2.dk'>"+ titleTextBox.Text +"</asp:HyperLink></li>";
    }
}