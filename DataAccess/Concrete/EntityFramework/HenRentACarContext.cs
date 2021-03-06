﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework
{
    public class HenRentACarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HenDevRentACar;Trusted_Connection=true"); //Work
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=HenRentACar;Trusted_Connection=true"); //Home
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<UserCard> UserCards { get; set; }
    }
}
