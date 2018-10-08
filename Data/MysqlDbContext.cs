using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using WebApp.Models.Data;

namespace WebApp.Models.Data
{
    public class MysqlDbContext : DbContext 
    {
        public MysqlDbContext(string _conString) {
            this.ConnectionString = _conString;
        }

        private string ConnectionString { get; set; }

        // DB definitions
        public DbSet<CoreData> CoreData { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
          => optionBuilder.UseMySql(ConnectionString);
    }
}