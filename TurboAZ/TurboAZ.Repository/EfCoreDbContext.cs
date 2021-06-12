using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;
using TurboAZ.Repository.Identity;

namespace TurboAZ.Repository
{
   public class EfCoreDbContext:IdentityDbContext<AppUser>
    {

        //public EfCoreDbContext(DbContextOptions<EfCoreDbContext> options) : base(options)
        //{

        //}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=COMPUTER\\NICATRED;Database=TurboAZ-QAZ;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfCoreDbContext).Assembly);

            modelBuilder.Entity<Model>().HasOne(c => c.Brand).WithMany(e => e.Models).OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
           
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ImageType> ImageTypes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Body> Bodies { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Valute> Valutes { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<GearBox> GearBox { get; set; }
        public DbSet<EngineVolume> EngineVolumes { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<Ad> Ads { get; set; }

    }
}
