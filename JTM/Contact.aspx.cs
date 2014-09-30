using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : Page
{
    SQLDatabase DB = new SQLDatabase("JTM.mdf","LocalDB","","");
    protected void Page_Load(object sender, EventArgs e)
    {
		try
		{
			DB.Open();
			string[][] contactsArray = DB.Query("SELECT * FROM contacts WHERE Id=1");

			string email = contactsArray[0][6];

			string htmlstring = "";
			htmlstring += contactsArray[0][1] + "<br />";
			htmlstring += contactsArray[0][2] + ", " + contactsArray[0][3] + "<br />";
			htmlstring += "<abbr title='Telefon'>Tlf: </abbr>" + contactsArray[0][4] + "<br />";
			htmlstring += "<abbr title='Mobiltelefon'>Mobil: </abbr>" + contactsArray[0][5];

			addressBox.InnerHtml = htmlstring;

			if (email != "" ||  email != null)
			{
				emailaddressBox.InnerHtml = "<strong>Salg:</strong>   <a href='mailto:" + email + "'>" + email + "</a><br />";
			}
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