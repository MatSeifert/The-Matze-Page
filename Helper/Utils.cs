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

        public static string GetConnectionString()
        {
            // Get Connection String from Config
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            return Configuration["ConnectionStrings:DefaultConnection"];
        }

        public static Dictionary<string, string> GetUiStrings(string lang) {
            // Get Connection String from Config
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            string content;
            using (StreamReader reader = File.OpenText(Configuration[$"UiStrings:{lang}"])) {
                content = reader.ReadToEnd();
            }

            var uiStrings = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);

            return uiStrings;  
        }
    }
}