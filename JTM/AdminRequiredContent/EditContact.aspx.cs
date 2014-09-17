using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminRequiredContent_EditContact : System.Web.UI.Page
{
    SQLDatabase DB = new SQLDatabase("JTM.mdf","LocalDB","","");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                DB.Open();
                string[][] contactsArray = DB.Query("SELECT * FROM contacts WHERE Id=1");

                AddressTextBox.Text = contactsArray[0][1].ToString();
                PostalTextBox.Text = contactsArray[0][2].ToString();
                CityTextBox.Text = contactsArray[0][3].ToString();
                PhoneTextBox.Text = contactsArray[0][4].ToString();
                HandphoneTexbox.Text = contactsArray[0][5].ToString();

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
    protected void Save_button_Click(object sender, EventArgs e)
    {
        DB.Open();
        DB.Exec("UPDATE contacts SET address='" + AddressTextBox.Text + "', postnr=" + PostalTextBox.Text + 
            ", city='" + CityTextBox.Text + "', tlf='" + PhoneTextBox.Text + "', mobile='" + HandphoneTexbox.Text + "' WHERE Id=1" +
            "IF @@ROWCOUNT=0 INSERT INTO contacts (Id, address, postnr, city, tlf, mobile) " +
            "VALUES (1, '"+ AddressTextBox.Text +"', "+ PostalTextBox.Text +", '"+ CityTextBox.Text +"', '"+ PhoneTextBox.Text +"', '"+ HandphoneTexbox.Text +"')");
        DB.Close();
    }
}