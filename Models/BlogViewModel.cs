using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApp.Models.Data;

namespace WebApp.Models 
{
    public class BlogAllViewModel 
    {
        public IEnumerable<BlogItem> BlogItems { get; set; }
        public BlogItem FeaturedPost { get; set; }
    }

    public class BlogPostViewModel 
    {
        public BlogItem Post { get; set; }
    }

    public class CreatePostViewModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Snippet")]
        public string Snippet { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        public int TitleImage { get; set; }
        
        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Tags")]
        public string Tags { get; set; }

        public int Gallery { get; set; }
    }
}