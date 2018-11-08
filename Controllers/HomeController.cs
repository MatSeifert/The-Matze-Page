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

        public async Task<IActionResult> Index(string lang)
        {
            var model = new HomeViewModel();
            Utils.CheckOrRefreshUiStrings(lang);
            ViewBag.Title = Utils.GetUiString("title.home");

            using (var db = new MysqlDbContext(this.ConnectionString))
            {
                model.CoreData = await db.CoreData.FirstOrDefaultAsync();
                var latestPosts = db.Posts.Where(p => p.IsPublished).Take(3);

                var blogItems = new List<BlogItem>();

                // Get related mediafiles
                foreach (var b in latestPosts) {
                    var blogItem = new BlogItem();

                    blogItem.Post = b;
                    blogItem.TitleImage = await db.Media.FirstOrDefaultAsync(m => m.Id == b.TitleImage);
                    // TODO: add galleries below!

                    blogItems.Add(blogItem);
                }

                model.LatestPosts = blogItems;
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