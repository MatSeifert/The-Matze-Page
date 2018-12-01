namespace WebApp.Models.Data 
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Content { get; set; }
        public bool IsFeatured { get; set; }
        public int TitleImage { get; set; }
    }
}