using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

public partial class Forum_SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string ComputeHash(string input, HashAlgorithm algorithm)
    {
        Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

        Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

        return BitConverter.ToString(hashedBytes);
    }

    protected void btnOpret_Click(object sender, EventArgs e)
    {
        SQLDatabase db = new SQLDatabase("ForumDB.mdf", "LocalDB", "", "");

        if (txtPassword.Text == txtConfPass.Text)
        {
            string password = ComputeHash(txtPassword.Text, new SHA256CryptoServiceProvider());

            try
            {
                db.Open();
                db.Exec("INSERT INTO Users(user_name, user_pass, user_email ,user_date, user_level) VALUES('" + txtUsername.Text + "', '" + password + "', '" + txtMail.Text + "', GETDATE(), 1)");
            }
            catch (Exception ex)
            {
                lblFejl.Text = "En fejl er muligvis opstået. Prøv igen.";
            }
            finally
            {
                content.InnerHtml = "Brugeren er nu oprettet. Du kan logge ind <a href='LogIn.aspx'>her</a>.";
                db.Close();
            }
        }
    }
}