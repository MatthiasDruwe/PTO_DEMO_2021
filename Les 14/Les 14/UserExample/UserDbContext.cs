using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExample
{
    class UserDbContext: DbContext
    {
        public UserDbContext():base ("data source=(localdb)\\MSSQLLocalDB; initial catalog= UserExample")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasKey((user) => new { user.FirstName, user.LastName });

            modelBuilder.Entity<User>()
                .HasMany((user) => user.Cars)
                .WithRequired((car) => car.User);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
