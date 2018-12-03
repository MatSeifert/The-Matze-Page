using System.Collections.Generic;
using WebApp.Models.Data;

namespace WebApp.Models
{
  public class PortfolioViewModel
  {
    public PortfolioItem Featured { get; set; }
    public IEnumerable<PortfolioItem> CaseStudies { get; set; }
  }

  public class CaseStudyViewModel
  {
    public string Name { get; set; }
  }
}