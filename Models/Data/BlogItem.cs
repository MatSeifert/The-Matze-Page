using System.Collections.Generic;

namespace WebApp.Models.Data {
  public class BlogItem {
    public Post Post { get; set; }
    public Media TitleImage { get; set; }
    public IEnumerable<Media> Gallery { get; set; }
  }
}