using Company.DataModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace Company
{
    public partial class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Personnel> Personnels { get; set; }

        public AppDBContext()
        {

        }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("data source=.;initial catalog=CompanyDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //    modelBuilder.Entity<User>().HasData(
            //        new User
            //        {
            //            id = 1,
            //            UserName = "mz",
            //            Pasword = "123",
            //            Personne
            //        });

            //    modelBuilder.Entity<Personnel>().HasData(
            //            new Personnel
            //            {
            //                id = 1,
            //                Name = "Muhammed",
            //                Surename = "Zayif",
            //                PhoneNumber = "5320000000",
            //                BirtDay = new DateTime(1980, 1, 1)
            //            }
            //        );
            //}
        }
    }
}
