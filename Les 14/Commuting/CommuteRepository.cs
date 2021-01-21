using Commuting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commuting
{
    // Responsibility => Database operaties
    class CommuteRepository
    {
        CommuteDbContext dbContext = new CommuteDbContext();

        public CommuteRepository()
        {
            dbContext.Database.EnsureCreated();
        }

        // Create => Insert
        public void CreateCommute(Commute commute)
        {
            switch (commute)
            {
                case Car car:
                    dbContext.Cars.Add(car);
                    break;
                case Bike bike:
                    dbContext.Bikes.Add(bike);
                    break;
                case Train train:
                    dbContext.Trains.Add(train);
                    break;
            }

            dbContext.SaveChanges();
        }

        // Read => Select
        public List<Commute> GetAllCommutes()
        {
            List<Car> cars = dbContext.Cars.ToList();
            List<Train> trains = dbContext.Trains.ToList();
            List<Bike> bikes = dbContext.Bikes.ToList();

            List<Commute> commutes = new List<Commute>();
            commutes.AddRange(cars);
            commutes.AddRange(trains);
            commutes.AddRange(bikes);

            return commutes ;
        }

        // Update
        public void UpdateCommute(Commute commute)
        {

        }

        // Delete
        public void DeleteCommute(Commute commute)
        {

        }
    }
}
