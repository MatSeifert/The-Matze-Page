namespace WebApp.Models.Data {
    public class CoreData {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Image { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        
        // Social Media Channels
        public string Twitter { get; set; }
        public string Dribbble { get; set; }
        public string Stackoverflow { get; set; }
        public string Xing { get; set; }
        public string Github { get; set; }
    }
}