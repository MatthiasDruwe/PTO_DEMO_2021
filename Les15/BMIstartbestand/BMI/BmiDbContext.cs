using BMI.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class BmiDbContext:DbContext
    {
        public BmiDbContext():base("data source=(localdb)\\MSSQLLocalDB; initial catalog = bmi2501 ")
        {

        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Bmi> BmiData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bmi>().HasKey(bmi => new { bmi.Date, bmi.UserId });
        }
    }
}
