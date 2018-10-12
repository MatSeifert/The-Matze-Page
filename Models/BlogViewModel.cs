using System.Collections.Generic;
using WebApp.Models.Data;

namespace WebApp.Models {
    public class BlogAllViewModel {
        public IEnumerable<BlogItem> BlogItems { get; set; }
        public BlogItem FeaturedPost { get; set; }
    }

    public class BlogPostViewModel {
        public BlogItem Post { get; set; }
    }
}