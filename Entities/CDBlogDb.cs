using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebApi.Entities
{
    public partial class CDBlogDb:DbContext
    {
        public CDBlogDb()
        {

        }  
        public DbSet<Users> Users { get; set; }
        public DbSet<Categorys> Categorys { get; set; }
        public DbSet<GroupMenu> GroupMenu { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<GroupUser> GroupUser { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Posts> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DbCoreConnectionString");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

    }
}
