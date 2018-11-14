using System.Collections.Generic;

using WebApp.Models.Data;

namespace WebApp.Models 
{
  public class AboutMeViewModel 
  {
    public IEnumerable<CvItem> CvEntries { get; set; }
    public IEnumerable<TestimonialItem> Testimonials { get; set; }
  }
}