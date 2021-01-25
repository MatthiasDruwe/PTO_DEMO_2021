using BMI.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Windows;

namespace BMI.Repository
{
    class BmiRepository
    {
        BmiDbContext dbContext = new BmiDbContext();

        // Create 
        public void CreateBmi(Bmi bmi)
        {
            dbContext.Users.Attach(bmi.User);
            dbContext.BmiData.Add(bmi);
            dbContext.SaveChanges();
        }

        // Read
        public List<Bmi> GetAllBmiFor(User user)
        {
            return dbContext.BmiData.Where(bmi => bmi.UserId == user.Id)
                  .ToList()
                  .OrderByDescending(bmi => bmi.BMI)
                  .ToList();
        }

        public List<Bmi> GetAllBmiFor(User user, TimePeriod period)
        {
            DateTime max = DateTime.Today;
            DateTime min;

            switch (period)
            {
                case TimePeriod.Week:
                    min = max.AddDays(-7);
                    break;
                case TimePeriod.Month:
                    min = max.AddMonths(-1);
                    break;
                case TimePeriod.Year:
                    min = max.AddYears(-1);
                    break;
                default:
                    return GetAllBmiFor(user);
                    break;

            }

            return dbContext.BmiData.Where(bmi => bmi.UserId == user.Id && bmi.Date <= max && bmi.Date > min)
                    .ToList()
                    .OrderByDescending(bmi => bmi.BMI)
                  .ToList();
        }

        public string GetMaxBmiFor(User user, TimePeriod period)
        {

            string max;
            try
            {
                max = GetAllBmiFor(user, period).Max(bmi => bmi.BMI).ToString();
            }
            catch (InvalidOperationException exception)
            {
                Debug.WriteLine(exception.ToString());
                Debug.WriteLine("-----");
                Debug.WriteLine(exception.Message);
                return "-";
            }
            catch (ArgumentNullException exception)
            {
                MessageBox.Show("NullRef exception");
                return "-";
            }

            return max;
        }

        // Update
        public void UpdateUser(Bmi bmi)
        {
            // dbContext.BmiData.Update(bmi);
            dbContext.Entry<Bmi>(bmi).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        // Delete 
        public void Delete(Bmi bmi)
        {
            dbContext.BmiData.Remove(bmi);
            dbContext.SaveChanges();
        }

    }
}
