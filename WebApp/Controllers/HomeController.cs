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

        public HomeController()
        {
            this.ConnectionString = Utils.GetConnectionString();
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomeViewModel();

            using (var db = new MysqlDbContext(this.ConnectionString))
            {
                model.CoreData = await db.CoreData.FirstOrDefaultAsync();
            }

            return this.View(model);
        }
    }
}
