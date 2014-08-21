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
    protected void confirm_Button_Click(object sender, EventArgs e)
    {
        DB.Open();
        DB.Exec("INSERT INTO productinfo (productname, amount, price, info) VALUES ('" + navnTextbox.Text + "', " + amountTextBox.Text + ", " + prisTextbox.Text + ", '" + infoTextbox.Text + "')");
            //content12.InnerHtml += "<p>" + getData[i][1] + i + "</p>";
        DB.Close();

        GridView1.DataBind();
    }

    protected void delete_Button_Click(object sender, EventArgs e)
    {
        DB.Open();
        //DB.Exec("DELETE FROM productinfo WHERE productid='"+produktidTextBox+"'");
        //content12.InnerHtml += "<p>" + getData[i][1] + i + "</p>";
        DB.Close();

        GridView1.DataBind();
    }

    protected void edit_Button_Click(object sender, EventArgs e)
    {
        DB.Open();
        //DB.Exec("UPDATE productinfo SET WHERE productid='"+produktidTextbox+*'");
        //content12.InnerHtml += "<p>" + getData[i][1] + i + "</p>";
        DB.Close();

        GridView1.DataBind();
    }
}