using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrMVC.Models;

namespace PrMVC.Data
{
    public class PrMVCContext : DbContext
    {
        public PrMVCContext (DbContextOptions<PrMVCContext> options)
            : base(options)
        {
        }

        public DbSet<PrMVC.Models.Department> Department { get; set; }
        public DbSet<PrMVC.Models.Seller> Seller { get; set; }
        public DbSet<PrMVC.Models.SalesRecord> SalesRecord { get; set; }
    }
}
