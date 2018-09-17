using System.IO;
using Microsoft.Extensions.Configuration;

namespace api.Helper
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

            return Configuration["ConnectionString:DefaultConnection"];
        }
    }
}