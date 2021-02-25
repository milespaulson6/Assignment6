using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class LetriniaDbContext : DbContext
    {
        //this is the database being made
        public LetriniaDbContext(DbContextOptions<LetriniaDbContext> options) : base (options)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
