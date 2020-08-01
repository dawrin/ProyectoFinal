using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{

    public class CarritoDbContex : DbContext
    {
        public CarritoDbContex(DbContextOptions<CarritoDbContex> options) : base(options)
        {

        }
        public DbSet<DataProductos> DATA { get; set; }
    }
}
