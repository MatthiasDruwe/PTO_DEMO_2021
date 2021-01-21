using System;
using System.Collections.Generic;
using System.Text;

namespace Commuting.Model
{
    public class Car: Commute
    {
        private double distance;
        private double parkingPrice;


        public double Distance { get => distance; set => distance = value; }
        public double ParkingPrice { get => parkingPrice; set => parkingPrice = value; }

        public Car(string origin, string destination, DateTime date, double distance) : base(origin, destination, date)
        {
            this.distance = distance;
        }

        public Car() : base()
        {

        }

        public override double CalculateRefund()
        {
            return distance * 0.23;
        }

        public override string ToString()
        {
            return "Car: " + base.ToString();
        }
    }
}
