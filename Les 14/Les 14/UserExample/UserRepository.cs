using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UserExample
{
    class UserRepository
    {
        UserDbContext dbContext = new UserDbContext();

        // Create
        public void CreateUser ( User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        // Read

        public List<User> GetAllUser()
        {
            return dbContext.Users.Include((user) => user.Cars).ToList();
        }

        public User GetUserWith(string firstName, string lastName)
        {
            return dbContext.Users
                .Where((user) => user.FirstName == firstName && user.LastName == lastName)
                .First();
        }

        public User GetUserWith2(string firstName, string lastName)
        {
            // Select *
            // FROM USers
            // WHERE first = ... AND lastname = ...

            return (from users in dbContext.Users
                    where users.FirstName == firstName && users.LastName == lastName
                    select users).First();
        }

        // Update 


        // Delete
    }
}
