using Microsoft.EntityFrameworkCore;
using Session08.Exercise.Domain;
using System;

namespace Session08.Exercise.DAL
{
    public class AppDbContext1 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; integrated security=true; initial catalog=S08-Ex-Db1;");
        }

        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child01> child01s { get; set; }
        public DbSet<Child02> child02s { get; set; }
    }
}
