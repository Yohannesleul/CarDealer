using CarDealership.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions options) : base(options) { }

       protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Car> cars { get; set; }
    }
}
