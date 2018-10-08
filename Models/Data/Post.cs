using System;

namespace WebApp.Models {
    public class Post {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Snippet { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int TitleImage { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
    }
}