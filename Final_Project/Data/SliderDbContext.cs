using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Data
{
    public class SliderDbContext :DbContext
    {
        public SliderDbContext(DbContextOptions<SliderDbContext> options)
           : base(options)
        {
        }
        public DbSet<DataProductos> Slider { get; set; }
    }
}
