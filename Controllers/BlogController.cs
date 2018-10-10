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

        public async Task<IActionResult> All(int? id)
        {
            var model = new BlogAllViewModel();
            ViewBag.UiStrings = this.UiStrings;
            ViewBag.Title = this.UiStrings["title.blog"];
            ViewBag.ActiveLink = 1;

            using (var db = new MysqlDbContext(this.ConnectionString))
            {
                // Coredata for footer
                ViewBag.CoreData = await db.CoreData.FirstOrDefaultAsync();

                // Get Posts from DB
                var posts = await db.Posts.ToListAsync();
                var blogItems = new List<BlogItem>();

                // Get related mediafiles
                foreach (var b in posts) {
                    var blogItem = new BlogItem();

                    blogItem.Post = b;
                    blogItem.TitleImage = await db.Media.FirstOrDefaultAsync(m => m.Id == b.TitleImage);
                    // TODO: add galleries below!

                    blogItems.Add(blogItem);
                }

                blogItems.OrderBy(d => d.Post.Date).ToList();
                model.FeaturedPost = blogItems.FirstOrDefault();
                model.BlogItems = blogItems;
            }

            return this.View(model);
        }
    }
}