using BMI.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.Repository
{
    class UserRepository
    {
        BmiDbContext dbContext = new BmiDbContext();
        // Create Vincent
        public void Create(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        // Read 

        public List<User> GetAllUsers()
        {
            return dbContext.Users.ToList();
        } 


        // Update
        public void UpdateUser(User user)
        {
            dbContext.Entry<User>(user).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        // Delete
        public void DeleteUser(User user)
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
    }
}
