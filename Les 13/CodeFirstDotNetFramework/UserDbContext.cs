using System.Data.Entity;

namespace CodeFirstDotNetFramework
{
    class UserDbContext : DbContext
    {
        // ~ UserLes13 Databank 
        public UserDbContext() : base("data source=(localdb)\\MSSQLLocalDB; initial catalog=UserLes13")
        {

        }


        //Tabellen
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
