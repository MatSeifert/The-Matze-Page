using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WebApp.Helper;
using WebApp.Models;
using WebApp.Models.Data;

namespace WebApp.Controllers
{
  public class PortfolioController : Controller 
  {
    private string ConnectionString { get; set; }

    public PortfolioController()
    {
      this.ConnectionString = Utils.GetConnectionString();
    }

    public async Task<IActionResult> Index(string lang) 
    {
      var model = new PortfolioViewModel();
      Utils.CheckOrRefreshUiStrings(lang);
      ViewBag.Title = Utils.GetUiString("title.portfolio");
      ViewBag.ActiveLink = 2;

      using (var db = new MysqlDbContext(this.ConnectionString)) 
      {
        var featuredItem = await db.Portfolio.FirstOrDefaultAsync(p => p.IsFeatured);
      }

      return this.View(model);
    }

    public async Task<IActionResult> CaseStudy(string id, string lang) 
    {
      var model = new CaseStudyViewModel();
      Utils.CheckOrRefreshUiStrings(lang);
      ViewBag.Title = Utils.GetUiString($"title.portfolio.{id}");
      ViewBag.ActiveLink = 2;
      model.Name = id;

      return this.View(model);
    }
  }
}