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
  public class ContactController : Controller 
  {
    private string ConnectionString { get; set; }
    private Dictionary<string, string> UiStrings { get; set; }

    public ContactController()
    {
      this.ConnectionString = Utils.GetConnectionString();
      this.UiStrings = Utils.GetUiStrings("de");
    }

    public async Task<IActionResult> Index() 
    {
      var model = new ContactViewModel();
      ViewBag.UiStrings = this.UiStrings;
      ViewBag.Title = this.UiStrings["title.contact"];
      ViewBag.ActiveLink = 3;

      return this.View(model);
    }
  }
}