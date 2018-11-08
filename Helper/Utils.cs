using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Microsoft.Extensions.Configuration;
using WebApp.Models;
using Newtonsoft.Json;

using WebApp.Models.Data;

namespace WebApp.Helper
{
    public class Utils
    {
        public static IConfiguration Configuration { get; set; }
        private static Dictionary<string, string> UiStrings { get; set; }

        // Reads the appconfig.json File and stores it in local variable
        private static void ReadAppConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        // Reads the UiStrigns File for a specified language and stores it in local variable.
        // Using German as fallback language, if specified language was not found
        private static void InitUiStrings(string lang) 
        {
            ReadAppConfig();

            lang = String.IsNullOrWhiteSpace(lang) ? "de" : lang; 

            using (StreamReader reader = File.OpenText(Configuration[$"UiStrings:{lang}"])) 
            {
                string content = reader.ReadToEnd();

                var uiStrings = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);

                UiStrings = uiStrings;
            }
        }

        // Returns the ConnectionString config entry from the configuration
        public static string GetConnectionString()
        {
            ReadAppConfig();
            return Configuration["ConnectionStrings:DefaultConnection"];
        }

        // Checks, if the UiStrings are loaded, or if the currently loaded UiStrings match the 
        // specific language. Loads or reloads them, if one condition matches
        public static void CheckOrRefreshUiStrings(string lang)
        {
            if (UiStrings == null || !GetUiString("lang").Equals(lang))
            {
                InitUiStrings(lang);
                return;
            }
        }

        // Returns a specific UiString from the currently active language file
        public static string GetUiString(string key) 
        {
            if (!UiStrings.ContainsKey(key))
            {
                return $"n/a: {key}";
            }

            return UiStrings[key];
        }

        // Gets the config entry for the loval debug URL to make the App available via network
        public static string GetDebugUrl()
        {
            ReadAppConfig();

            return Configuration["DevSettings:DebugUrl"];
        }
    }
}