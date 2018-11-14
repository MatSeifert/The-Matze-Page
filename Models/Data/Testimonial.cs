namespace WebApp.Models.Data
{
  public class Testimonial
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public string Organization { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public int? RelatedProject { get; set; }
    public int Image { get; set; }
  }
}