using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MatzeApp.Controllers
{
    public class HomeController : Controller 
    {  
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public ActionResult Index() {
            var path = _hostingEnvironment.WebRootPath + "\\index.html";
            var fileBytes = System.IO.File.ReadAllBytes(path);            
            FileContentResult file = File(fileBytes, "text/html");
            return file;
        }
    }
}