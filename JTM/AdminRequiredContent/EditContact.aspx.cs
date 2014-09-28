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
                HandphoneTextbox.Text = contactsArray[0][5].ToString();
                EmailTextBox.Text = contactsArray[0][6].ToString();
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
        string address = AddressTextBox.Text;
        string postal = PostalTextBox.Text;
        string city = CityTextBox.Text;
        string phone = PhoneTextBox.Text;
        string mobile = HandphoneTextbox.Text;
        string mail = EmailTextBox.Text;

        DB.Open();
        DB.Exec("UPDATE contacts SET address='" + address + "', postnr=" + postal + 
            ", city='" + city + "', tlf='" + phone + "', mobile='" + mobile + "', email='" + mail + "' WHERE Id=1" +
            "IF @@ROWCOUNT=0 INSERT INTO contacts (Id, address, postnr, city, tlf, mobile, email) " +
            "VALUES (1, '"+ address +"', "+ postal +", '"+ city +"', '"+ phone +"', '"+ mobile +"', '"+ mail +"')");
        DB.Close();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "success", "alert('Kontakt er nu gemt.'); setInterval(function(){location.href='EditProfilePage.aspx';},3000);", true);
    }
}