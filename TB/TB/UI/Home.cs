using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using TB.Core;

namespace TB.UI
{
    public class Home : ContentPage
    {
        public Home()
        {
            var reddit = State.Reddit;
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = $"Hello {reddit.User.Name}!\n\nYou have {reddit.User.LinkKarma} link karma." }
                }
            };
        }
    }
}
