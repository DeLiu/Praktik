﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using crypto;

public partial class Forum_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SQLDatabase Db = new SQLDatabase("ForumDB.mdf", "localDB", "", "");
        try
        {
            Db.Open();
            string[][] getuser = Db.Query("SELECT user_name, user_pass, userlevel FROM Users where user_name = '" + username.Value + "'");
            for (int i = 0; i < getuser.Length; i++)
            {
                if (PasswordHash.ValidatePassword(password.Value, getuser[i][1]) == true)
                {
                    HttpCookie cookie = new HttpCookie("forumcookie");
                    cookie.Values.Add("username", getuser[i][0]);
                    cookie.Values.Add("userlevel", getuser[i][2]);
                    cookie.Expires = DateTime.Now.AddDays(60);
                    Response.Redirect("Default.aspx");       
                }
                else
                {
                    content.InnerHtml = "<p>Forkert kode eller brugernavn prøv igen.</p>";
                }
            }
        }
        catch (Exception ex)
        {
            
        }
        finally
        {
            Db.Close();
        }
    }
}