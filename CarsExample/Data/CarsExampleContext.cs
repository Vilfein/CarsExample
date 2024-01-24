using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarsExample.Models;

namespace CarsExample.Data
{
    public class CarsExampleContext : DbContext
    {
        public CarsExampleContext (DbContextOptions<CarsExampleContext> options)
            : base(options)
        {
        }

        public DbSet<CarsExample.Models.Car> Car { get; set; } = default!;
        public DbSet<CarsExample.Models.Driver> Driver { get; set; } = default!;
    }
}
