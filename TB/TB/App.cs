using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using RedditSharp;

namespace TB
{
    public class App : Application
    {
        public App()
        {
            var reddit = new Reddit();
            var user = reddit.LogIn(TB.Properties.Resources.REDDIT_USERNAME, TB.Properties.Resources.REDDIT_PASSWORD);
            var subreddit = reddit.GetSubreddit("/r/al_dev");

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = subreddit.Name //"Welcome to Xamarin Forms!"
                        }
                    }
                }
            };
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
