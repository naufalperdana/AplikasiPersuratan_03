using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppReport03.Models;

namespace WebAppReport03.DB
{
    public class AplikasiSuratContext : DbContext
    {
        public AplikasiSuratContext(DbContextOptions<AplikasiSuratContext> options) : base(options)
        {

        }
        public DbSet<TblSrtTugas> TblSrtTugass { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblSrtTugas>().ToTable("TblSrtTugas");
        }
    }
}
