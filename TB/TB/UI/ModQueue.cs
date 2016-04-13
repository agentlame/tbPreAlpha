using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using RedditSharp;
using TB.Core;
using Xamarin.Forms;
using TB.UI.Controls;


namespace TB.UI
{
    public class ModQueue : ContentPage
    {
        private Reddit reddit = State.Reddit;
        public ModQueue()
        {
            var modqueue = reddit.User.ModerationQueue;
            var listings = modqueue.GetListing(100);
            var stackLayout = new StackLayout();

            // Set layout styling.
            stackLayout.VerticalOptions = LayoutOptions.Start;
            stackLayout.Spacing = 10;

            foreach (var listing in listings)
            {
                Utils.Log(listing.Kind);
                Utils.Log(listing.FullName);
                Utils.Log(listing.Upvotes);
                Utils.Log(listing.Title);
                //Utils.Log(listing);
                if (listing.Kind == "t3")
                {
                    var text = $"{listing.Title} by /u/{listing.Author} in {listing.Subreddit} score: {listing.Score}";
                    Utils.Log(text);

                    // well, that's not working
                    //stackLayout.Children.Add(new PostView { Author = listing.Author.Name, Title = listing.Title, Subreddit = listing.Subreddit.Name });

                    stackLayout.Children.Add(new Label { Text = text });
                }
            }

            Content = stackLayout;
        }
    }
}
