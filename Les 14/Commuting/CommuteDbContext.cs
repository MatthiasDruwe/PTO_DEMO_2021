using System;
using System.Collections.Generic;
using System.Text;
using Commuting.Model;
using Microsoft.EntityFrameworkCore;

namespace Commuting
{
    class CommuteDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CommuteDB;");
        }

/*        
        private DbSet<Commute> commutes;

        public DbSet<Commute> Commutes
        {
            get { return commutes; }
            set { commutes = value; }
        }
*/

        public DbSet<Train> Trains { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bike> Bikes { get; set; }
    }
}
