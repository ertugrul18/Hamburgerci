using Hamburgerci.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Entities.Contexts
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Menu> Menuler { get; set; }
        public DbSet<Extra> Extralar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<SiparisMaster> SiparisMaster { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylari { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer(@"Server=(localdb)\mssqllocaldb;
                                         Database=Hamburgerci;
                                         Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .Property(p => p.MenuAdi).HasMaxLength(50);

            modelBuilder.Entity<Menu>()
                .HasIndex(p => p.MenuAdi).IsUnique();

            modelBuilder.Entity<Extra>()
                .Property(p => p.ExtraAdi).HasMaxLength(50);

            modelBuilder.Entity<Extra>()
               .HasIndex(p => p.ExtraAdi).IsUnique();

            modelBuilder.Entity<Kullanici>()
                .Property(p => p.Adi).HasMaxLength(50);

            modelBuilder.Entity<Kullanici>()
                .Property(p => p.SoyAdi).HasMaxLength(50);

            modelBuilder.Entity<Kullanici>()
                .Property(p => p.KullaniciAdi).HasMaxLength(50);

            modelBuilder.Entity<Kullanici>()
                .Property(p => p.Sifre).HasMaxLength(50);

            modelBuilder.Entity<Kullanici>()
                .HasIndex(p => p.KullaniciAdi).IsUnique();




        }
    }



}
