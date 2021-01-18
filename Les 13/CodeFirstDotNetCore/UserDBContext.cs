using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstDotNetCore
{
    class UserDBContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=(localdb)\\MSSQLLocalDB; initial catalog=usersles13Bis");
        }

        //Tabellen
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
