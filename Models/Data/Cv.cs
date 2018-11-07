using System;

namespace WebApp.Models.Data 
{
    public class Cv 
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public String EmployerLabel { get; set; }
        public String EmployerUrl { get; set; }
        public String EmployerDescription { get; set; }
        public String Label { get; set; }
        public String Description { get; set; }
        public int? Attachment { get; set; }
        public int? Thumbnail { get; set; }
        public String Type { get; set; }
    }
}