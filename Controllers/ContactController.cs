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

    public ContactController()
    {
      this.ConnectionString = Utils.GetConnectionString();
    }

    public async Task<IActionResult> Index(string lang) 
    {
      var model = new ContactViewModel();
      Utils.CheckOrRefreshUiStrings(lang);
      ViewBag.Title = Utils.GetUiString("title.contact");
      ViewBag.ActiveLink = 3;

      return this.View(model);
    }
  }
}