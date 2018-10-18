using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Microsoft.Extensions.Configuration;
using WebApp.Models;
using Newtonsoft.Json;

namespace WebApp.Helper
{
    public class Utils
    {
        public static IConfiguration Configuration { get; set; }

        private static void ReadAppConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public static string GetConnectionString()
        {
            ReadAppConfig();
            return Configuration["ConnectionStrings:DefaultConnection"];
        }

        public static Dictionary<string, string> GetUiStrings(string lang) 
        {
            ReadAppConfig();

            var rfp = Configuration[$"UiStrings:{lang}"];

            using (StreamReader reader = File.OpenText(Configuration[$"UiStrings:{lang}"])) {
                string content = reader.ReadToEnd();

                var uiStrings = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);

                return uiStrings;  
            }
        }

        public static string GetDebugUrl()
        {
            ReadAppConfig();

            return Configuration["DevSettings:DebugUrl"];
        }
    }
}