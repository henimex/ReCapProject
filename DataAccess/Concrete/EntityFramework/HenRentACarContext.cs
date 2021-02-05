using System;
using System.Collections.Generic;
using System.Text;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class HenRentACarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HenDevRentACar;Trusted_Connection=true");
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=HenRentACar;Trusted_Connection=true");/
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
