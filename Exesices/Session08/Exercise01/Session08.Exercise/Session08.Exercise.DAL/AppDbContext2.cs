using Microsoft.EntityFrameworkCore;
using Session08.Exercise.Domain;
using System;

namespace Session08.Exercise.DAL
{
    public class AppDbContext2 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; integrated security=true; initial catalog=S08-Ex-Db2;");
        }

        public DbSet<EntityInAnotherContext> EntityInAnotherContexts { get; set; }
    }
}
