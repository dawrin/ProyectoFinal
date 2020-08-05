using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Data
{
    public class OrdenesDbContext : DbContext
    {
        public OrdenesDbContext(DbContextOptions<OrdenesDbContext> options)
           : base(options)
        {
        }
        public DbSet<DataProductos> Orden { get; set; }


    }
}
