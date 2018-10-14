using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
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

        public async Task<IActionResult> Index(int? id)
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

        public async Task<IActionResult> Post(int id) 
        {
            var model = new BlogPostViewModel();
            ViewBag.UiStrings = this.UiStrings;
            ViewBag.ActiveLink = 1;

            var postItem = new BlogItem();

            using (var db = new MysqlDbContext(this.ConnectionString))
            {
                // Coredata for footer
                ViewBag.CoreData = await db.CoreData.FirstOrDefaultAsync();

                var post = await db.Posts.SingleOrDefaultAsync(b => b.Id == id);
                var titleImage = await db.Media.SingleOrDefaultAsync(i => i.Id == post.TitleImage);
                // TODO: add gallery
                postItem.Post = post;
                postItem.TitleImage = titleImage;

                ViewBag.Title = $"{post.Title} | {this.UiStrings["title.blog"]} ";
            }

            model.Post = postItem;

            return this.View(model);
        }

        [Authorize]
        public IActionResult CreatePost()
        {
            ViewBag.UiStrings = this.UiStrings;
            ViewBag.ActiveLink = 1;
            ViewBag.Title = this.UiStrings["title.blog.create"];

            return this.View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SavePost(BlogItem blogItem)
        {
            using (var db = new MysqlDbContext(this.ConnectionString))
            {
                var addedBlogPost = await db.Posts.AddAsync(blogItem.Post);
                var addedTitleImage = await db.Media.AddAsync(blogItem.TitleImage);

                // redirectto home if no entities were saved (because whatever)
                // TODO: return to specific error page
                if (await db.SaveChangesAsync() == 0)
                {
                    return this.RedirectToAction("index", "home");
                }

                // redirect directly to new blogpost
                return this.RedirectToAction("index", "blog", new { id = addedBlogPost.Entity.Id });
            }
        }
    }
}