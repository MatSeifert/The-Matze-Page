using System.Collections.Generic;

namespace WebApp.Models {
    public class BlogAllViewModel {
        public IEnumerable<Post> AllBlogPosts { get; set; }
    }
}