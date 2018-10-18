using System;
using System.Collections.Generic;

using WebApp.Models.Data; 

namespace WebApp.Models.Data {
    public class Post {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Snippet { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int TitleImage { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
        public int? Gallery { get; set; }
        public int ReadCount { get; set; }
        public int LikeCount { get; set; }
        public bool IsPublished { get; set; }
    }
}