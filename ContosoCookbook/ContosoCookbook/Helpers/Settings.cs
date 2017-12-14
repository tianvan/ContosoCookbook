using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCookbook.Helpers
{
    public class Settings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        private static Lazy<Settings> s_instance = new Lazy<Settings>(() => new Settings());

        public static Settings Current => s_instance.Value;

        public string UserName
        {
            get => AppSettings.GetValueOrDefault(nameof(UserName), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(UserName), value);
        }
    }
}
