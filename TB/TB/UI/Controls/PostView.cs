using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TB.UI.Controls
{
    public class PostView : ContentView
    {
        public string Title { get; set;}
        public string Author { get; set; }
        public string ThingID { get; set; }
        public string Permalink { get; set; }
        public string URL { get; set; }
        public string Text { get; set; }
        public string Subreddit { get; set; }

        public PostView()
        {
            Content = new Label { Text = $"{Title} by /u/{Author} in /r/{Subreddit}" };
        }
    }
}
