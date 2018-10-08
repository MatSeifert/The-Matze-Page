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
    public class BlogController : Controller
    {
        private string ConnectionString { get; set; }

        private Dictionary<string, string> UiStrings { get; set; }

        public BlogController()
        {
            this.ConnectionString = Utils.GetConnectionString();
            this.UiStrings = Utils.GetUiStrings("de");
        }

        public async Task<IActionResult> All(int? page)
        {
            var model = new BlogAllViewModel();
            ViewBag.UiStrings = this.UiStrings;

            using (var db = new MysqlDbContext(this.ConnectionString))
            {
                // Coredata for footer
                ViewBag.CoreData = await db.CoreData.FirstOrDefaultAsync();

                model.AllBlogPosts = await db.Posts.ToListAsync();
            }

            return this.View(model);
        }
    }
}