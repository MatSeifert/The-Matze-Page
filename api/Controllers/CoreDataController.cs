using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using api.Helper;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class CoreDataController : Controller
    {
        private string ConnectionString { get; set; }

        public CoreDataController()
        {
            this.ConnectionString = Utils.GetConnectionString();
        }

        // GET api/coredata
        [HttpGet]
        public async Task<CoreData> Get()
        {
           using (var db = new MysqlDbContext(this.ConnectionString))
           {
               return await db.CoreData.FirstOrDefaultAsync();
           }
        }

        // POST api/coredata
        [HttpPost]
        public async Task<IActionResult> Create(CoreData data)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest("Invalid ModelState");
            }

            using (var db = new MysqlDbContext(this.ConnectionString))
            {
                await db.CoreData.AddAsync(data);
                await db.SaveChangesAsync();

                return Created($"/api/coredata/{data.Id}", data);
            }
        }

        // PUT api/coredata
        [HttpPut]
        public async Task<IActionResult> Update(CoreData data)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest("Invalid ModelState");
            }

            using (var db = new MysqlDbContext(this.ConnectionString))
            {
                var updatedCoreData = await db.CoreData.FirstOrDefaultAsync(d => d.Id == data.Id);

                if (updatedCoreData == null)
                {
                    return NotFound();
                }

                // update values
                updatedCoreData.FirstName = data.FirstName;
                updatedCoreData.LastName = data.LastName;
                updatedCoreData.Image = data.Image;
                updatedCoreData.StreetName = data.StreetName;
                updatedCoreData.StreetNumber = data.StreetNumber;
                updatedCoreData.ZipCode = data.ZipCode;
                updatedCoreData.City = data.City;
                updatedCoreData.PhoneNumber = data.PhoneNumber;
                updatedCoreData.Mobile = data.Mobile;
                updatedCoreData.Email = data.Email;

                // Save
                await db.SaveChangesAsync();
                
                return Ok(data);
            }
        }
    }
}
