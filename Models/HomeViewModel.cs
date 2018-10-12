using System.Collections.Generic;
using WebApp.Models.Data;

namespace WebApp.Models
{
    public class HomeViewModel {
        public CoreData CoreData { get; set; }
        public List<BlogItem> LatestPosts { get; set; } 
    }
}