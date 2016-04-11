using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using RedditSharp;
using TB.Core;
using Xamarin.Forms;

namespace TB.UI
{
    public class Login : ContentPage
    {
        private Entry usernameEntry, passwordEntry;
        private Button loginButton;        

        public Login()
        {
            PopulateControls();

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Children = {
                    usernameEntry,
                    passwordEntry,
                    loginButton
                }
            };
        }

        private void PopulateControls()
        {
            usernameEntry = new Entry { Placeholder = "Username" };
            passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true
            };
            loginButton = new Button { Text = "Login" };

            loginButton.Clicked += LoginButton_Clicked;
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            State.Reddit = new Reddit();
            try
            {
                State.Reddit.LogIn(usernameEntry.Text, passwordEntry.Text, true);
            }
            catch
            {
                DisplayAlert("Nope", "Bad username or password", "OK");
                return;
            }

            DisplayAlert("Yay!", $"You logged in as {State.Reddit.User.Name}", "OK");

            Settings.REDDIT_USERNAME = usernameEntry.Text;
            Settings.REDDIT_PASSWORD = passwordEntry.Text;

            Navigation.PopAsync();
        }
    }
}
