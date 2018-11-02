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
    private Dictionary<string, string> UiStrings { get; set; }

    public PortfolioController()
    {
      this.ConnectionString = Utils.GetConnectionString();
      this.UiStrings = Utils.GetUiStrings("de");
    }

    public async Task<IActionResult> Index() 
    {
      var model = new PortfolioViewModel();
      ViewBag.UiStrings = this.UiStrings;
      ViewBag.Title = this.UiStrings["title.portfolio"];
      ViewBag.ActiveLink = 2;

      return this.View(model);
    }
  }
}