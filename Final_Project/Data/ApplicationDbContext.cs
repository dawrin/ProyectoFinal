using System;
using System.Collections.Generic;
using System.Text;
using Final_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<DataProductos> Productos { get; set; }
        public DbSet<OrdenesModel> Ordenes { get; set; }
        //public DbSet<DataProductos> Ordenes1 { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Roles> Roles { get; set; }
    }
}
