using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WebApp.Helper;
using WebApp.Models;
using WebApp.Models.Data;

namespace WebApp.Controllers
{
  public class AboutMeController : Controller
  {
    private string ConnectionString { get; set; }

    public AboutMeController()
    {
      this.ConnectionString = Utils.GetConnectionString();
    }

    public async Task<IActionResult> Index(string lang) 
    {
      lang = String.IsNullOrWhiteSpace(lang) ? "de" : lang;

      var model = new AboutMeViewModel();
      Utils.CheckOrRefreshUiStrings(lang);
      ViewBag.Title = Utils.GetUiString("title.aboutMe");
      ViewBag.ActiveLink = 0;

      using (var db = new MysqlDbContext(this.ConnectionString))
      {
        // CV
        var cvEntries = await db.Cv.ToListAsync();
        cvEntries = cvEntries.OrderByDescending(c => c.StartDate).ToList();
        var cvItems = new List<CvItem>();
        
        // Testimonials
        var testimonials = await db.Testimonials.ToListAsync();
        var testimonialItems = new List<TestimonialItem>();

        foreach(var cv in cvEntries) 
        {
          var cvItem = new CvItem();
          cvItem.Entry = cv;

          var attachment = await db.Media.FirstOrDefaultAsync(m => m.Id == cv.Attachment);
          var thumbnail = await db.Media.FirstOrDefaultAsync(m => m.Id == cv.Thumbnail);

          if (attachment != null) 
          {
            cvItem.Attachment = attachment;
          }

          if (thumbnail != null) 
          {
            cvItem.Thumbnail = thumbnail;
          }

          cvItems.Add(cvItem);
        }

        foreach(var t in testimonials)
        {
          var tItem = new TestimonialItem();
          tItem.Testimonial = t;

          var image = await db.Media.FirstOrDefaultAsync(i => i.Id == t.Image);

          if (image != null) {
            tItem.Image = image;
          }

          testimonialItems.Add(tItem);
        }

        model.CvEntries = cvItems;
        model.Testimonials = testimonialItems;
      }

      return this.View(model);
    }
  }
}