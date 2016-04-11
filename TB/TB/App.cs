using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using RedditSharp;
using TB.UI;
using TB.Core;

namespace TB
{
    public class App : Application
    {
        public App()
        {
            var username = Settings.REDDIT_USERNAME;
            var password = Settings.REDDIT_PASSWORD;

            // If the settings are empty, we've never logged in.
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MainPage = new NavigationPage(new Login());
                //MainPage = new NavigationPage(new Home());
            }
            else
            {
                State.Reddit = new Reddit();
                try
                {
                    State.Reddit.LogIn(username, password, true);
                }
                catch
                {
                    // Saved password didn't work, so show login form anyways.
                    MainPage = new NavigationPage(new Login());
                }

                MainPage = new NavigationPage(new Home());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
