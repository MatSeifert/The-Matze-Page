using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WebApp.Helper;
using WebApp.Models;
using WebApp.Models.Data;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private string ConnectionString { get; set; }

        private Dictionary<string, string> UiStrings { get; set; }

        public HomeController()
        {
            this.ConnectionString = Utils.GetConnectionString();
            this.UiStrings = Utils.GetUiStrings("de");
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomeViewModel();
            ViewBag.UiStrings = this.UiStrings;
            ViewBag.Title = this.UiStrings["title.home"];

            using (var db = new MysqlDbContext(this.ConnectionString))
            {
                model.CoreData = await db.CoreData.FirstOrDefaultAsync();
                ViewBag.CoreData = model.CoreData;
            }

            return this.View(model);
        }
    }
}

/*
Login                 https://localhost:5001/Identity/Account/Login
Register              https://localhost:5001/Identity/Account/Register
Profilseite           https://localhost:5001/Identity/Account/Manage
*/