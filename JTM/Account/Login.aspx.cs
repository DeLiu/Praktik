﻿using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using JTM;
using crypto;

public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
            
            RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
             
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                SQLDatabase DB = new SQLDatabase("ForumDB.mdf", "LocalDB", "", "");

                try
                {
                    DB.Open();
                    string[][] userlog = DB.Query("SELECT user_name, user_pass, userlevel FROM Users WHERE user_name='" + UserName.Text + "'");

                    if (PasswordHash.ValidatePassword(Password.Text, userlog[0][1]) == true)
                    {
                        Session.Add("User", userlog[0][0]);
                        Session.Add("Pass", userlog[0][1]);
                        Session.Add("level", userlog[0][2]);
                        Session.Timeout = 5;
                        //IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                        //Response.Redirect(Request.UrlReferrer.ToString());
                    }
                    else
                    {
                        FailureText.Text = "Forkert kode eller brugernavn prøv igen.";
                        ErrorMessage.Visible = true;
                    }
                }
                catch (Exception ex)
                { }
                finally
                {
                    DB.Close();
                }
            }

            /*
            if (IsValid)
            {
                // Validate the user password
                var manager = new UserManager();
                ApplicationUser user = manager.Find(UserName.Text, Password.Text);
                if (user != null)
                {
                    IdentityHelper.SignIn(manager, user, RememberMe.Checked);
                    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                }
                else
                {
                    FailureText.Text = "Invalid username or password.";
                    ErrorMessage.Visible = true;
                }
            } */
        }
}