using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace api.Models
{
    public class MysqlDbContext : DbContext 
    {
        public MysqlDbContext(string _conString) {
            this.ConnectionString = _conString;
        }

        private string ConnectionString { get; set; }

        // DB definitions
        public DbSet<CoreData> CoreData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
          => optionBuilder.UseMySql(ConnectionString);
    }
}