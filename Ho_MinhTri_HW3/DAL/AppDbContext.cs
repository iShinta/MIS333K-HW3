﻿using Ho_MinhTri_HW3.Models;
using System.Data.Entity;

namespace Ho_MinhTri_HW3.DAL
{
    public class AppDbContext : DbContext
    {
        //Constructor that invokes the base constructor
        public AppDbContext() : base("MyDBConnection") { }

        //Create the db set
        public DbSet<Customer> Customers { get; set; }
    }
}