using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminRequiredContent_EditProductPage : System.Web.UI.Page
{
    SQLDatabase DB = new SQLDatabase("JTM.mdf", "LocalDB", "", "");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void confirmButton_Click(object sender, EventArgs e)
    {
        DB.Open();
        DB.Exec("INSERT INTO productinfo (productname, amount, price, info) VALUES ('"+navnTextbox.Text+"', "+amountTextBox.Text+", "+prisTextbox.Text+", '"+infoTextbox.Text+"')");
            //content12.InnerHtml += "<p>" + getData[i][1] + i + "</p>";
        DB.Close();
    }
}