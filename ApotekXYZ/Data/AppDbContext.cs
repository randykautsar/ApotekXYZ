using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApotekXYZ.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Apoteker> Apoteker { get; set; }

        public DbSet<Obat> Obat { get; set; }

        public DbSet<Transaksi> Transaksi { get; set; }
    }
}
