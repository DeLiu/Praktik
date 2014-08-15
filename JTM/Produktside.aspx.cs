using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Produktside : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] dbarray= productDBstring.SelectCommand("select * from productinfo");
        for (int i = 0; i < dbarray.Length ; i++)
			{
			 productcontent.InnerHtml = "<p>HELLO WORLD</p>";
			}
        
    }
}