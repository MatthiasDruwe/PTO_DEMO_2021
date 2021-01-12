using System;
using System.Collections.Generic;
using System.Text;

namespace Commuting.Model
{
    public class Car: Commute
    {
        private double distance;

        public Car(string origin, string destination, DateTime date, double distance):base(origin, destination, date)
        {
            this.distance = distance;
        }


        public override double CalculateRefund()
        {
            return distance * 0.23;
        }

        public override string ToCSVLine()
        {
            return $"Car;{base.ToCSVLine()};{distance}";
        }

        public override string ToString()
        {
            return "Car: " + base.ToString();
        }
    }
}
