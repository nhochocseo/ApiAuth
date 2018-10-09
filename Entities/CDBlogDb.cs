using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class CDBlogDb:DbContext
    {
        public CDBlogDb(DbContextOptions<CDBlogDb> options)
            : base(options)
        { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Categorys> Categorys { get; set; }
        public DbSet<GroupMenu> GroupMenu { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<GroupUser> GroupUser { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Posts> Posts { get; set; }
    }
}
