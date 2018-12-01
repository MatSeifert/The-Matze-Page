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

      return this.View(model);
    }

    public async Task<IActionResult> CaseStudy() 
    {
      return this.View();
    }
  }
}