// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace TB.Core
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string redditUsername = "REDDIT_USERNAME";
        private static readonly string usernameDefault = string.Empty;

        private const string redditPassword = "REDDIT_PASSWORD";
        private static readonly string passwordDefault = string.Empty;

        #endregion

        public static string REDDIT_USERNAME
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(redditUsername, usernameDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(redditUsername, value);
            }
        }

        public static string REDDIT_PASSWORD
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(redditPassword, passwordDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(redditPassword, value);
            }
        }

    }
}