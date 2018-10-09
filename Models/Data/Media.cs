namespace WebApp.Models.Data {
  public class Media {
    public int Id { get; set; }
    public string Label { get; set; }
    public string Type { get; set; }
    public string Url { get; set; }
    public int? GalleryId { get; set; }
  }
}