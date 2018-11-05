using System.Collections.Generic;

using WebApp.Models.Data;

namespace WebApp.Models 
{
  public class AboutMeViewModel 
  {
    public IEnumerable<Cv> CvEntries { get; set; }
  }
}