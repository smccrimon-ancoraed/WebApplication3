using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Address> Address { get; set; }
        public DbSet<Customer> Customer { get; set; }
        // public DbSet<WebApplication3.Models.Address> Address { get; set; }
        // public DbSet<WebApplication3.Models.Customer> Customer { get; set; }
    }
}
