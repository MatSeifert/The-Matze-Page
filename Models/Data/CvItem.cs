using System.Collections.Generic;

namespace WebApp.Models.Data 
{
  public class CvItem {
    public Cv Entry { get; set; }
    public Media Thumbnail { get; set; }
    public Media Attachment { get; set; }
  }
}