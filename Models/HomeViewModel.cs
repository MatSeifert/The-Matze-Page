using System.Collections.Generic;
using WebApp.Models.Data;

namespace WebApp.Models
{
    public class HomeViewModel {
        public CoreData CoreData { get; set; }
        public Dictionary<string, string> UiStrings { get; set; }
    }
}